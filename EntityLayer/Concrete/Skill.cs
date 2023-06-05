using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key]
        public int skillid { get; set; }
        public string  title { get; set; }
        public string Description { get; set; }
        public string skill1 { get; set; }
        public string skill2 { get; set; }
        public string skill3 { get; set; }
        public string skill4 { get; set; }
    }
}
