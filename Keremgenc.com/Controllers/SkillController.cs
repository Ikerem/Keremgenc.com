using BussinesLayer.Conrete;
using Dataaccses.EntityFreamWork;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Keremgenc.com.Controllers
{
    public class SkillController : Controller
    {
        EFSkillManager skillManager=new EFSkillManager(new EFSkillDal());
        public IActionResult Index()
        {
            var values = skillManager.tGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddSkill()
        {

            return View();
        }
        [HttpPost]
        public IActionResult AddSkill(Skill skill)
        {
            skillManager.tInsert(skill);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteSkill(int id)
        {
            var values = skillManager.tGetByID(id);
            skillManager.tDelete(values);

            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult EditSkill(int id)
        {

            var values = skillManager.tGetByID(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult EditSkill(Skill skill)
        {
            skillManager.tUpdate(skill);
            return RedirectToAction("Index");

        }
    }
}
