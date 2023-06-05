using BussinesLayer.Abstract;
using Dataaccses.Abstrack;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Conrete
{
    public class EFSkillManager : ISkillService
    {
        ISkillDal _skillDal;

        public EFSkillManager(ISkillDal skillDal)
        {
            _skillDal = skillDal;
        }

        public void tDelete(Skill t)
        {
         _skillDal.Delete(t);
        }

        public Skill tGetByID(int id)
        {
          return _skillDal.GetByID(id);
        }

        public List<Skill> tGetList()
        {
          return _skillDal.GetList();
        }

        public void tInsert(Skill t)
        {
            _skillDal.Insert(t);
        }

        public void tUpdate(Skill t)
        {
            _skillDal.Update(t);
        }
    }
}
