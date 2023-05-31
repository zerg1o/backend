namespace back_end.DTOs
{
    public class TareaCreacionDTO
    {
        public string? descripcion { get; set; }

        public DateTime? fecha_inicio { get; set; }

        public DateTime? fecha_fin { get; set; }

        public string? estado { get; set; }
    }
}
