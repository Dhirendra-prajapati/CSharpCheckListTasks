using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public delegate void Delegate1(int a);
    internal class Program
    {
        //public static void method(int num)
        //{
        //     num += 10;
        //    Console.WriteLine(num);
        //}
        static void Main(string[] args)
        {
            Delegate1 obj = delegate(int num)
            {
                num += 10;
                Console.WriteLine(num);
            };   
            obj.Invoke(12);
            Console.ReadLine();

        }
    }
}
