using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
