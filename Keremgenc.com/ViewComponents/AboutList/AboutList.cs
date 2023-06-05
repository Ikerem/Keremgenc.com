using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.ViewComponents.HeaderList
{
    public class AboutList:ViewComponent
    {
        EFAboutManager EFAboutManager = new EFAboutManager(new EFAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = EFAboutManager.tGetList();
            return View(values);
        }
    }
}
