using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Models
{
    public class Categoria : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
