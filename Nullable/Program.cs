using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = null;
            DateTime date2 = date ??DateTime.Now;
            Console.WriteLine(date2);

            //DateTime? date = null;
            //Console.WriteLine("GetValueordefaule"+date.GetValueOrDefault());
            //Console.WriteLine(date.HasValue);
            //Console.WriteLine(date.Value);
            Console.ReadLine();
        }
    }
}
