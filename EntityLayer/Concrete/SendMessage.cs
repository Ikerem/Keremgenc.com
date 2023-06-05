using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class SendMessage
    {
        [Key]
        public int SendMessageid { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }
    }
}
