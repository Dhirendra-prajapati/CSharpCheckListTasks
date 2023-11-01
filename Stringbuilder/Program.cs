using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stringbuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append('_', 10);
            sb.AppendLine();
            sb.Append("header");
            sb.AppendLine();
            sb.Append('_', 10);
            sb.Replace('_', '+');
            sb.Remove(0, 10);
            sb.Insert(0, new string('_', 10));
            Console.WriteLine(sb);
            Console.WriteLine("first char:"+ sb[0]);
            Console.ReadLine();
        }
    }
}
