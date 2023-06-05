using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.ViewComponents.MyPricingList
{
    public class MyPricingList:ViewComponent
    {
     EFMyPricingManager _myPricingManager=new EFMyPricingManager(new EFMyPricingDal());
        public IViewComponentResult Invoke()
        {
           var values = _myPricingManager.tGetList();
            return View(values);
        }
    }
}
