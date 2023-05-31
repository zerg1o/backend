namespace back_end.DTOs
{
    public class PaginacionDTO
    {
        public int pagina { get; set; } = 1;
        public int recordsPorPagina  = 10;
        private readonly int cantidadMaximarecordsPorPagina =50;

        public int RecordsPorPagina
        {
            get
            {
                return recordsPorPagina;
            }

            set{
                recordsPorPagina = (value > cantidadMaximarecordsPorPagina) ? cantidadMaximarecordsPorPagina : value;
            }
        }
    }
}
