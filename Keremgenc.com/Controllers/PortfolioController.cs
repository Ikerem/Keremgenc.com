using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.Controllers
{
    public class PortfolioController : Controller
    {
        EFProjectManager EFProjectManager = new EFProjectManager(new EFProjectDal());
        public IActionResult Index()
        {
            var values = EFProjectManager.tGetList();
            return View(values);
        }
        [HttpGet]   
        public IActionResult UpdatePortfolio(int id)
        {
            var values = EFProjectManager.tGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdatePortfolio(Projects projects)
        {
            EFProjectManager.tUpdate(projects);
            return RedirectToAction("Index");
        }

        public IActionResult DeletePortfolio(int id)
        {
            var values = EFProjectManager.tGetByID(id);
            EFProjectManager.tDelete(values);

                return RedirectToAction("Index");   

        }
        [HttpGet]
        public IActionResult AddPortfolio()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddPortfolio(Projects projects)
        {
            EFProjectManager.tInsert(projects);
            return RedirectToAction("Index");
        }

    }
}
