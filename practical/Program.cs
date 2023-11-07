using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practical
{
    internal class Program
    {
        
       
        static void Main(string[] args)
        {
            Func<int, int> square = number => number * number;
            Console.WriteLine("The square of number"+square(5));
            const int factor = 5;
            Func<int, int> multipler = number => number * factor;
            int result = multipler(10);
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
