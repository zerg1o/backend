using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace back_end.Entidades
{
    public class Tarea 
    {
        public int id { get; set; }
        [Required]
        public string? descripcion { get; set; }
        [Required]
        public DateTime? fecha_inicio { get; set; }
        [Required]
        public DateTime? fecha_fin { get; set; }
        [Required]
        public int id_usu_asignado { get; set; }
        [Required]
        public string? estado { get; set; }
        DateTime result;
        DateTime fechaini, fechafin;
        DateTime fecha_actual = DateTime.Now;
        
    }
}
