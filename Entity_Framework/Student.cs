using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    public class Student
    {
       public int StudentId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set;}
        public DateTime? DatePublished { get; set; }
        public category category { get; set; }  
        public decimal Height { get; set; }
        public virtual Standard Standard { get; set; }  

    }
}
