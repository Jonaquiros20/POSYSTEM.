using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Controllers
{
    public class VentasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
