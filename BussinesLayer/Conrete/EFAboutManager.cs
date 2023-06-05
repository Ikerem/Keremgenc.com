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
    public class EFAboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public EFAboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void tDelete(About t)
        {
            throw new NotImplementedException();
        }

        public About tGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> tGetList()
        {
            return _aboutDal.GetList();
        }

        public void tInsert(About t)
        {
            throw new NotImplementedException();
        }

        public void tUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}
