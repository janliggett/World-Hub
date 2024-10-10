using Microsoft.AspNetCore.Mvc;


namespace WorldHub.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
