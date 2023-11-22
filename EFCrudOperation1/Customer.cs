﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCrudOperation1
{
    public class Customer
    {
        public int id { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}