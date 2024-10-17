using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WorldHub.Controllers
{
    public class AshaController : Controller
    {
        //public IActionResult Index()
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
        public IActionResult Rules5e()
        {
            return View();
        }
        public IActionResult Chargen()
        {
            return View();
        }
        public IActionResult Attegan()
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
    }
}
