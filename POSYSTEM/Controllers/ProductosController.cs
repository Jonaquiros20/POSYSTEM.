using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
