using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class Stack
    {
        private readonly List<object> _list=new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Cannot add a null object in the stack");
            _list.Add(obj);
        }
        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There are no element in the stack");
            int index = _list.Count - 1;
            var toreturn = _list[index];
            _list.RemoveAt(index);
            return (toreturn);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            int initial = 1;
            int max = 5;
            for (int i = initial; i <= max; i++)
                stack.Push(i);
            for (int i = initial; i <= max; i++)
                Console.WriteLine(stack.Pop());
            Console.ReadLine();


        }
    }
}
