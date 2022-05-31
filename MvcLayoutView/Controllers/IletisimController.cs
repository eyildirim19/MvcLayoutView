using Microsoft.AspNetCore.Mvc;

namespace MvcLayoutView.Controllers
{
    public class IletisimController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
