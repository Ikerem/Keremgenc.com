using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.Controllers
{
    public class MyPricingController : Controller
    {
        EFMyPricingManager myPricingManager = new EFMyPricingManager(new EFMyPricingDal());
        public IActionResult Index()
        {
            var values = myPricingManager.tGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult EditPricing(int id)
        {

            var values = myPricingManager.tGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditPricing(MyPricing myPricing)
        {
            myPricingManager.tUpdate(myPricing);
            return RedirectToAction("Index");

        }
        public IActionResult DeletePricing(int id)
        {
            var values = myPricingManager.tGetByID(id);
            myPricingManager.tDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult AddMyPricing()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddMyPricing(MyPricing myPricing)
        {
            myPricingManager.tInsert(myPricing);
            return RedirectToAction("Index");
        }

    }
}
