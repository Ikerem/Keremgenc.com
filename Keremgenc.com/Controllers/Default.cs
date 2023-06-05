using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Keremgenc.com.Controllers
{
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }
		public PartialViewResult FooterPartial()
		{
			return PartialView();
		}
		public PartialViewResult ScriptPartial()
		{
			return PartialView();
		}
		public PartialViewResult NavBarPartial()
		{
			return PartialView();
		}




	}
}
