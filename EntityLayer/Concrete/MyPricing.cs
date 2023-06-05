using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MyPricing
    {
        [Key]
        public int MyPricingid { get; set; }
        public string ımg { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string descriptio2 { get; set; }
        public string descriptio3 { get; set; }
        public string descriptio4 { get; set; }
        public string descriptio5 { get; set; }
        public string price { get; set; }
      
    }
}
