﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int Aboutid { get; set; }
        public string ImageUrl { get; set; }
        public string title1 { get; set; }
        public string Description { get; set; }
      
        public string ProjectDowlandUrl { get; set; }
    }
}
