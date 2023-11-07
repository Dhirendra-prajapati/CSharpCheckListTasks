using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Interpolation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string
            string s1 = "hello";
            string s2 = "world";
            Console.WriteLine(s1+" "+s2);
            //string builder
            StringBuilder sb=new StringBuilder();
            sb.Append('_', 10);
            sb.AppendLine();
            sb.Append("header");
            Console.WriteLine(sb);

            //string interpolation
            int n1 = 10;
            int n2 = 20;
            string s = $"The sum of {n1} and {n2} is {n1 + n2}";
            Console.WriteLine(s);



            Console.ReadLine(); 
        }
    }
}
