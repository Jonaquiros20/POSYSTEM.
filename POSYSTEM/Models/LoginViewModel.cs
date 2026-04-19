using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Models
{
    public class LoginViewModel : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
