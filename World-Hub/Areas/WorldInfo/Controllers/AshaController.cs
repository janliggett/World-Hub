using Microsoft.AspNetCore.Mvc;

namespace WorldHub.Areas.WorldInfo.Controllers
{
    [Area("WorldInfo")]
    public class AshaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AkalushanNorth()
        {
            return View();
        }

        public IActionResult CEU()
        {
            return View();
        }

        public IActionResult Kalshan()
        {
            return View();
        }
        public IActionResult Vindral()
        {
            return View();
        }

        public IActionResult SeishuneseWest()
        {
            return View();
        }
        public IActionResult DrechenExpanse()
        {
            return View();
        }
        public IActionResult Deities()
        {
            return View();
        }
        public IActionResult Groups()
        {
            return View();
        }
    }
}
