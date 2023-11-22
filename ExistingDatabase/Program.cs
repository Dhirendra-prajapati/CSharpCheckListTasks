using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExistingDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(ExistingDb DBEntities=new ExistingDb())
            {
                List<Employee> listStudent=DBEntities.Employees.ToList();
                Console.WriteLine();
                foreach(Employee emp in listStudent)
                {
         Console.WriteLine($"Name = {emp.Name} Email = {emp.Email}  gender = {emp.Gender} Salary={emp.salary} department = {emp.departmentId} ");
                }
                Console.ReadLine();
            }
        }
    }
}
