using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_expression
{
    public static class StringExtension
    {
        public static string shorten(this string str,int numberofwords)
        {
            if (numberofwords < 0)
                throw new ArgumentOutOfRangeException("number of words should be greater or equal to 0");
            if (numberofwords == 0)
                return "";
            var words=str.Split(' ');
            if (words.Length < numberofwords)
                return str;
            return string.Join(" ", words.Take(numberofwords))+"......";
        }
    }
    internal class Program
    {
     
        static void Main(string[] args)
        {
            string post = "This supposed to be long blog post blah blah blah blah.";
            var shortendPost = post.shorten(5);
            Console.WriteLine(shortendPost);
            IEnumerable<int> number = new List<int>() { 2, 4, 6, 8, 9 };
            var max = number.Max();
            Console.WriteLine(max);
            Console.ReadLine();

        }
    }
}
