using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.ViewComponents.testimonialList
{
    public class testimonialList : ViewComponent
    {
        EFTestimonialManager EFTestimonialManager= new EFTestimonialManager(new EFTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = EFTestimonialManager.tGetList();
            return View(values);
        }
    }
}
