using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace WorldHub.Controllers
{
    public class AshaController : Controller
    {

        public IActionResult Index()
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
        
        public IActionResult Guide() {
            return View();
        }

        public IActionResult Attegan()
        {
            return View();
        }
    }
}
