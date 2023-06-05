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
    public class EFProjectManager : IProjectService
    {
        private readonly IProjectDal _projectDal;

        public EFProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }

        public void tDelete(Projects t)
        {
           _projectDal.Delete(t);
        }

        public Projects tGetByID(int id)
        {
            return _projectDal.GetByID(id); 
        }

        public List<Projects> tGetList()
        {
           return _projectDal.GetList();
        }

        public void tInsert(Projects t)
        {
            _projectDal.Insert(t);
        }

        public void tUpdate(Projects t)
        {
            _projectDal.Update(t);
        }
    }
}
