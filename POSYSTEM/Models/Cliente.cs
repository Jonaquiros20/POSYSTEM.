using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Models
{
    public class Cliente : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
