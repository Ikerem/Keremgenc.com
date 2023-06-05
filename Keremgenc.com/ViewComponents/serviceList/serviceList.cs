using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace Keremgenc.com.ViewComponents.serviceList
{
    public class serviceList:ViewComponent
    { 
        EFSkillManager EFSkillManager= new EFSkillManager(new EFSkillDal());
        public IViewComponentResult Invoke()
        {
            var values= EFSkillManager.tGetList();
            return View(values);
        }
    }
}
