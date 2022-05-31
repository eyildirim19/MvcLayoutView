using Microsoft.AspNetCore.Mvc;

namespace MvcLayoutView.Controllers
{
    public class HakkimizdaController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
