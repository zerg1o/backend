using System.ComponentModel.DataAnnotations;

namespace back_end.DTOs
{
    public class TareaDTO
    {
        public int id { get; set; }
        
        public string? descripcion { get; set; }
     
        public DateTime? fecha_inicio { get; set; }
    
        public DateTime? fecha_fin { get; set; }
  
        public int id_usu_asignado { get; set; }
  
        public string? estado { get; set; }
    }
}
