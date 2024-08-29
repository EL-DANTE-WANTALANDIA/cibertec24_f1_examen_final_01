using Microsoft.AspNetCore.Mvc;
using SistemaColegio.Dominio.Repositories;

namespace SistemaColegio.WebMVC.Controllers
{
    public class NotasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
