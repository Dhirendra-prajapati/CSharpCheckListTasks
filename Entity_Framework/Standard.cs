﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class Standard
    {
        public int StandardId { get; set;}
        public string StandardName { get; set; }
        public string Description { get; set; }
        public ICollection<Student> students { get; set; }
    }
}
 