using BussinesLayer.Conrete;
using Dataaccses.Abstrack;
using Dataaccses.EntityFreamWork;
using Microsoft.AspNetCore.Mvc;


namespace Keremgenc.com.ViewComponents.portfolioList
{
    public class portfolioList:ViewComponent
    {
       EFProjectManager EFProjectManager= new EFProjectManager(new EFProjectDal());
        public IViewComponentResult Invoke()
        {
            var values = EFProjectManager.tGetList();   
            return View(values); 
        }
        
    }
}
