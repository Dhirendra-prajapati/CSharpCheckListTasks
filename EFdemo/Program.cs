using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFdemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                using (DemoEntities DBEntities = new DemoEntities())
                {
                    List<Department> listDepartment = DBEntities.Departments.ToList();
                    Console.WriteLine();
                    foreach (Department dept in listDepartment)
                    {
                        Console.WriteLine("Dept = {0} . Location = {1}", dept.Name, dept.Location);

                        foreach (Employee emp in dept.Employees)
                        {
                            Console.WriteLine("\t Name={0} Email = {1} Gender ={2} Salary = {3} ", emp.Name, emp.Email, emp.Gender, emp.salary);
                        }
                        Console.WriteLine();

                    }
                    Console.ReadLine();
                }

            }
        }
}    }