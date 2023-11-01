using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overriding
{
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw method of shape class");
        }
    }
    public class Circle : Shape
    {
        public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw method of Circle class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Draw();
            Console.ReadLine();

        }
    }
}
