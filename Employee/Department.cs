﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Department
    {
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        public  virtual ICollection<Emp> Employees { get; set; }

    }
}
