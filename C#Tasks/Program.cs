using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Tasks
{
    public class Student
    {
        public int id;
        public string name;
      public Student(int id,string name)
        {
            this.id = id;
            this.name = name;
            Console.WriteLine("Constructor invoke");

        }
        public void display()
        {
            Console.WriteLine(id +" "+name);
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            var c= new Student(12,"dhirendra");
            c.display();
            Console.ReadLine();
        }
    }
}
