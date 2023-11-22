using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutRefkeyword
{
    internal class Program
    {
        public static void Passbyref(ref int value)
        {
            value = value * value;

        }
        public static void PassByout(out int value1)
        {
            value1 = 20;
            value1=value1 * value1;

        }
        static void Main(string[] args)
        {
            //ref keyword
            int value = 10;
            Passbyref(ref value);
            Console.WriteLine(value);
            //out keyword
            int value1;
            PassByout(out value1);
            Console.WriteLine(value1);
            Console.ReadLine();

        }
    }
}
