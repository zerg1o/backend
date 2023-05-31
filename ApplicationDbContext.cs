﻿using back_end.Entidades;
using Microsoft.EntityFrameworkCore;

namespace back_end
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Tarea> Tareas { get; set; }
    }
}
