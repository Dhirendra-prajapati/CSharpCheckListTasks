using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Student
    {
       public void add(int num1,int num2)
        {
            Console.WriteLine("Addition of {0} and {1} is = {2}",num1,num2,(num1+num2));

        }
        public void add(int num1,int num2,int num3)
        {
            Console.WriteLine("Addition of {0}  {1} and {2} is = {3} ",num1,num2,num3,(num1+num2+num3));

        }
        public void add(float n1,float n2)
        {
            Console.WriteLine("Addition of {0} and {1} is =  {2}",n1,n2,(n1+n2));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();
            s1.add(20,30);
            s1.add(20, 30, 40);
            s1.add(75.24f, 12.34f);
            Console.ReadLine();
        }
    }
}
