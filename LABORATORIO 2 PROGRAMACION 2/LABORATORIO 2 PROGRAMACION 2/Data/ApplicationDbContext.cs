using LABORATORIO_2_PROGRAMACION_2.Dominio;
using LABORATORIO_2_PROGRAMACION_2.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LABORATORIO_2_PROGRAMACION_2.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
           : base(options) 
        {

        }

       

        public DbSet<Entidad> Entidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

        }

    }
}
