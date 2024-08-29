using SistemaColegio.Dominio.Modelo;
using SistemaColegio.Dominio.Repositories;
using SistemaColegio.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaColegio.Infraestructura.Repositories
{

    public class AlumnoRepository : IAlumnoRepository
    {
        private readonly ColegioDbContext _dbContext;

        public AlumnoRepository(ColegioDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Alumno> Consultar(string nombres)
        {
            //throw new NotImplementedException();
            var alumnos = _dbContext.Alumnos
                .Where(p => (nombres == null || p.Nombres.Contains(nombres)))
                .ToList();
            return alumnos;
        }
    }
}
