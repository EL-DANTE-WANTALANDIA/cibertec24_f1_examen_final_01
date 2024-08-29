using Microsoft.AspNetCore.Mvc;
using SistemaColegio.Dominio.Repositories;

namespace SistemaColegio.WebMVC.Controllers
{
    public class MatriculasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
