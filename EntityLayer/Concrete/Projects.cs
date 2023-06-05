using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Projects
    {
        [Key]
        public int Projectid { get; set; }
        public string Imge { get; set; }
        public string Title { get; set; }
        public string description { get; set; }
    }
}
