using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Models
{
    public class Usuario : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
