using Microsoft.AspNetCore.Mvc;

namespace MvcLayoutView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}