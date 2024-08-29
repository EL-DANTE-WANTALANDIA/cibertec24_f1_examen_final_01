using Microsoft.EntityFrameworkCore;
using SistemaColegio.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaColegio.Infraestructura.Datos
{
    public class ColegioDbContext : DbContext
    {
        public ColegioDbContext(DbContextOptions options): base(options) 
        {
        }
        public DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(
                parametro =>
                {
                    parametro.ToTable("Alumno");
                    parametro.HasKey(campo => campo.AlumnoID);
                    //p.Property(c => c.Codigo).HasColumnName("colNombre");

                    parametro.Property(campo => campo.Nombres);
                }

                );
        }

    }
}
