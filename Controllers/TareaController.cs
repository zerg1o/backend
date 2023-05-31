using AutoMapper;
using back_end.DTOs;
using back_end.Entidades;
using back_end.Utilidades;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers
{
    [Route("api/tareas")]
    [ApiController]
    //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    public class TareaController:ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;

        public TareaController(ApplicationDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet] //obtener todas las tareas
        public async Task<ActionResult<List<TareaDTO>>> Get([FromQuery] PaginacionDTO paginacionDTO)
        {
            var queryable =   context.Tareas.AsQueryable();
            await HttpContext.InsertParamHeaderPage(queryable);
            var tareas = await queryable.OrderBy(x => x.descripcion).Paginar(paginacionDTO).ToListAsync();
            return mapper.Map<List<TareaDTO>>(tareas);
        }
        [HttpGet("{id:int}")] // obtener tarea por id
        public async Task<ActionResult<TareaDTO>> Get(int id)
        {
            var tarea = await context.Tareas.FirstOrDefaultAsync(x => x.id == id);
            if (tarea==null)
            {
                return NotFound();
            }
            return mapper.Map<TareaDTO>(tarea);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] TareaCreacionDTO tareaCreacion)
        {
            var tarea = mapper.Map<Tarea>(tareaCreacion);
            context.Add(tarea);
            await context.SaveChangesAsync();
            return NoContent();
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id,[FromBody] TareaCreacionDTO tareaCreacionDTO)
        {
            var tarea = await context.Tareas.FirstOrDefaultAsync(x => x.id == id);
            if (tarea == null)
            {
                return NotFound();
            }
            tarea = mapper.Map(tareaCreacionDTO,tarea);
            await context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}
