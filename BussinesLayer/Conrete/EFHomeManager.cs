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
    public class EFHomeManager : IHomeService
    {
        private readonly IHomeDal _homeDal;

        public EFHomeManager(IHomeDal homedal)
        {
            _homeDal = homedal;
        }
        public void tDelete(Home t)
        {
            throw new NotImplementedException();
        }

        public Home tGetByID(int id)
        {
           return _homeDal.GetByID(id);
        }

        public List<Home> tGetList()
        {
           return _homeDal.GetList();
        }

        public void tInsert(Home t)
        {
          _homeDal.Insert(t);
        }

        public void tUpdate(Home t)
        {
           _homeDal.Update(t);
        }
    }
}
