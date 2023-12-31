﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    public class StudentAddress
    {
        [   Key,ForeignKey("Student")]
        public int StudentId { get; set;}
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [NotMapped]
        public string Zipcode { get; set; }
        public virtual Student Student { get; set; }   

    }
}
