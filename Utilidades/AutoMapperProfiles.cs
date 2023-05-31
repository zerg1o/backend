using AutoMapper;
using back_end.DTOs;
using back_end.Entidades;

namespace back_end.Utilidades
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Tarea, TareaDTO>().ReverseMap();
            CreateMap<TareaCreacionDTO, Tarea>().ReverseMap();
        }
    }
}
