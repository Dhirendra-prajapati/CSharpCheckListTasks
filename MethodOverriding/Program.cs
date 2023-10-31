using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    public class Employee
    {
        public int id;
        public string name;
        public int age;
        public Employee()
        {
            Console.WriteLine("Default constructor invoke");

        }
        public Employee(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine("parameterized constructor  invoke");
        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + age);
        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee();
            var e2 = new Employee(12, "dhirendra", 21);
            e2.display();
            Console.ReadLine();

        }
    }
}
