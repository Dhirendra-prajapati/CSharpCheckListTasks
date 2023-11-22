using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkOperation
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    
        public decimal Price { get; set; }
        public bool Availability { get; set; }
    }
}
