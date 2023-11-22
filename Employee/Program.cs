﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyDbContext db=new MyDbContext();
                Department d=new Department();
                d.DeptId = 2;
                d.DeptName = "Development";
                db.Departments.Add(d);
                db.SaveChanges();
                Console.WriteLine("Db Created");

            }
            catch(Exception e)
            {
                Console.WriteLine("Error" + e.ToString());
            }

        }
    }
}
