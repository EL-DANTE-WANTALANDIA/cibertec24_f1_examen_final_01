using Microsoft.AspNetCore.Mvc;
using SistemaColegio.Dominio.Repositories;

namespace SistemaColegio.WebMVC.Controllers
{
    public class AlumnosController : Controller
    {
        private readonly IAlumnoRepository _alumnosRepository; 
        public AlumnosController(IAlumnoRepository alumnoRepository)
        {
            _alumnosRepository = alumnoRepository;
        }
        public IActionResult Index()
        {
            var alumnos = _alumnosRepository.Consultar(null);
            ViewBag.ListaAlumnos = alumnos;
            return View();
        }
    }
}
