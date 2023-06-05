using BussinesLayer.Abstract;
using Dataaccses.Abstrack;
using Dataaccses.Repostories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesLayer.Conrete
{
    public class EFMyPricingManager : IMyPricingService
    {
        private readonly IMyPricingDal _myPricingDal;

        public EFMyPricingManager(IMyPricingDal myPricingDal)
        {
            _myPricingDal = myPricingDal;
        }

        public void tDelete(MyPricing t)
        {
            _myPricingDal.Delete(t);
        }

        public MyPricing tGetByID(int id)
        {
            return _myPricingDal.GetByID(id);
        }

        public List<MyPricing> tGetList()
        {
            return _myPricingDal.GetList();
        }

        public void tInsert(MyPricing t)
        {
            _myPricingDal.Insert(t);
        }

        public void tUpdate(MyPricing t)
        {
            _myPricingDal.Update(t);
        }
    }
}
