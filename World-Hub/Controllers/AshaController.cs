using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WorldHub.Controllers
{
    //[Area("Places")]
    public class AshaController : Controller
    {
        public IActionResult CEU()
        {
            //return View("~/Views/Asha/Places/CEU.cshtml");
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
        public IActionResult AkalushanNorth()
        {
            return View();
        }


        public IActionResult Index()
        {
            return View();
        }
        public IActionResult World()
        {
            return View();
        }
        public IActionResult Deities()
        {
            return View();
        }
        public IActionResult Rules()
        {
            return View();
        }
        public IActionResult Chargen()
        {
            return View();
        }
        public IActionResult TravelRules() { 
            return View();
        }
        public IActionResult Groups()
        {
            return View();
        }
        public IActionResult Guide() {
            return View();
        }

        public IActionResult Attegan()
        {
            return View();
        }
    }
}
