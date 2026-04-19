using Microsoft.AspNetCore.Mvc;

namespace POSYSTEM.Controllers
{
    public class ReportesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
