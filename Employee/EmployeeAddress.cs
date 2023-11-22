using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public  class EmployeeAddress
    {
        public int EmpId { get; set; }
        public string AddressLine1 { get; set;}
        public string AddressLine2 { get; set;}
        public string City { get; set; }
        public string ZipCode { get; set;}
        public virtual Emp Emp { get; set; }
     

    }
}
