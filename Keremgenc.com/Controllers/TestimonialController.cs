using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.Controllers
{
    public class TestimonialController : Controller
    {
        EFTestimonialManager EFTestimonialManager= new EFTestimonialManager(new EFTestimonialDal());
        public IActionResult Index()
        {
            var values = EFTestimonialManager.tGetList();
            return View(values);
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var values = EFTestimonialManager.tGetByID(id);
            EFTestimonialManager.tDelete(values);
            return RedirectToAction("Index");

        }
    }
}
