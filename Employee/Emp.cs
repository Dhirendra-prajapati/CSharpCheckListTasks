using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Emp
    {
      public int EmpId { get; set; }
        public string EmpName { get; set; }
        public float Salary { get; set; }
        public string Email { get; set; }
        public string PrimaryContact { get; set; }
        public string SecondaryContact { get; set; }
        public int DeptId {  get; set; }
        public int? TeamId { get; set; }

        public virtual Department Department { get; set; }
        public virtual EmployeeAddress EmployeeAddress { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Project> Projects{ get; set; }
    }
}
