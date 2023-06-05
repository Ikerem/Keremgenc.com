using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.ViewComponents.AboutList
{
    public class HomaPage:ViewComponent
    {
        EFHomeManager EFHomeManager= new EFHomeManager(new EFHomeDal());
        public IViewComponentResult Invoke()
        {
            var values = EFHomeManager.tGetList();
            return View(values);
        }
    }
}
