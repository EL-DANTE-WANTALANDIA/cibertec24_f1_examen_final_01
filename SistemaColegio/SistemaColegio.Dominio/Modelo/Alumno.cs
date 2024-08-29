using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaColegio.Dominio.Modelo
{
    public class Alumno
    {
        public short AlumnoID { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public string? Direccion { get; set; }
        public char? Sexo { get; set; }
        public DateOnly FechaNacimiento { get; set; }
    }
}
