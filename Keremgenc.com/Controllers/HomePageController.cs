using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.Controllers
{
    public class HomePageController : Controller
    {
        EFHomeManager EFHomeManager = new EFHomeManager(new EFHomeDal());
        public IActionResult Index()
        {
            var values = EFHomeManager.tGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditHomePage(int id)
        {
            var values = EFHomeManager.tGetByID(id);
            return View(values);

        }
        [HttpPost]
        public IActionResult EditHomePage(Home home)
        {
          EFHomeManager.tUpdate(home);


            return RedirectToAction("Index");
        }
    }
}
