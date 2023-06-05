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
    public class EFTestimonialManager : ITestimonialService
    {
        private readonly ITestimonialdAL _testimonialdAL;

        public EFTestimonialManager(ITestimonialdAL testimonialdAL)
        {
            _testimonialdAL = testimonialdAL;
        }

        public void tDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial tGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonial> tGetList()
        {
            return _testimonialdAL.GetList();   
        }

        public void tInsert(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void tUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }
}
