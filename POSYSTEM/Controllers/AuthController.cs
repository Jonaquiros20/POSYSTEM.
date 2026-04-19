using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
