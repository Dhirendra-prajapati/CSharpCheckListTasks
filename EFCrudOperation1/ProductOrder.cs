﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCrudOperation1
{
    public class ProductOrder
    {
        public int Id {  get; set; }
        public int Quantity {  get; set; }
        public int Productid { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }    
    }
}
