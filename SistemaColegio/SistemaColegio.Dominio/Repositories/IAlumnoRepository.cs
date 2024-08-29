using SistemaColegio.Dominio.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaColegio.Dominio.Repositories
{
    public interface IAlumnoRepository
    {
        public IEnumerable<Alumno> Consultar(string nombres);
    }
}
