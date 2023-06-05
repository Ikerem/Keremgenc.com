using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.Controllers
{
    public class AboutController : Controller
    {
        EFAboutManager FAboutManager= new EFAboutManager(new EFAboutDal());
        public IActionResult Index()
        {
            var values = FAboutManager.tGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var values = FAboutManager.tGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            FAboutManager.tUpdate(about);
            return RedirectToAction("Index");
        }
    }
}
