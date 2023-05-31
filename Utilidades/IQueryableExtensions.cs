﻿using back_end.DTOs;

namespace back_end.Utilidades
{
    public static class IQueryableExtensions
    {
        public static IQueryable<T> Paginar<T>(this IQueryable<T> queryable, PaginacionDTO paginacionDTO) 
        {
            return queryable.Skip((paginacionDTO.pagina - 1) * paginacionDTO.recordsPorPagina).Take(paginacionDTO.recordsPorPagina);
        
        }
    }
}
