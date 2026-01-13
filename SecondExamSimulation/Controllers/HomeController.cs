using Microsoft.AspNetCore.Mvc;

namespace SecondExamSimulation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
