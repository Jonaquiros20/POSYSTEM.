using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Models
{
    public class Producto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
