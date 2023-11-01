using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_problem
{
    public class Stack
    {
        private readonly List<object> _list = new List<object>();
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("cannot add a null object in the stack");
            _list.Add(obj);

        }
        public object Pop()
        {
            if (_list.Count == 0)
                throw new InvalidOperationException("There are no element in the stack");
            var index = _list.Count - 1;
            var toReturn = _list[index];
            _list.RemoveAt(index);  
            return (toReturn);

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            int ini = 10;
            int max = 12;
            for (int i = ini; i <= max; i++)
                stack.Push(i);
            for (int i = ini; i <= max; i++)
                Console.WriteLine( stack.Pop());


            Console.ReadLine();
        }
    }
}
