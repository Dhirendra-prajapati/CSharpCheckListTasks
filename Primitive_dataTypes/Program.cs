using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primitive_dataTypes
{
    public class Demonstrate
    {
        public void display()
        {
            Console.WriteLine("Hello World");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Primitive data type
            int integerNumber = 50;
            float floatNumber = 2.24f;
            double doubleNumber = 3.14156;
            bool isTrue = true;
            char character = 'D';
            Console.WriteLine("Integer Type :"+integerNumber);
            Console.WriteLine("Float Type:"+ floatNumber);
            Console.WriteLine("Double Type :"+doubleNumber);
            Console.WriteLine("Boolean type :"+isTrue);
            Console.WriteLine("Character type :"+character);

            //Non-Primitive data type
            Demonstrate dm=new Demonstrate();//object create
            dm.display();
            String str = "Hello World";
            int[] array = { 10, 20, 30 };
            DateTime date= DateTime.Now;
            Console.WriteLine("string :"+ str);
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Current datetime :"+date);
            Console.ReadLine();

        }
    }
}
