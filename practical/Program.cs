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
            List<int> numbers = new List<int>() { 2,3,4,5,6,7,8,9,12,13,14,15};
            foreach(int i in numbers)
            {
                Console.WriteLine(i);
            }
            var square = numbers.Select(n => n * n);
            Console.WriteLine("square of number");
            foreach(int n in square)
                Console.WriteLine(n);

            Console.ReadLine();

        }
    }
}
