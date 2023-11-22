using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(EFCodeFirstContext context=new EFCodeFirstContext())
            {
                var stud = new Student() { FirstName = "dhirendra", LastName = "Prajapati" };
                context.Students.Add(stud);
                context.SaveChanges();
                Console.WriteLine("student data added");
                Console.ReadLine();

            }

        }
    }
}
