using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.Controllers
{
    public class AdminController : Controller
    {

      
        public IActionResult Header()
        {
            return View();
        }
        public IActionResult SideBar()
        {
            return View();
        }
        public IActionResult NavBar()
        {
            return View();
        }
    }
}
