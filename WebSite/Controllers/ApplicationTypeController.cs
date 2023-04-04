using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    public class ApplicationTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
