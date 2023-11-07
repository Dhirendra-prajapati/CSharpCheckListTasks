using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Asynchronous
{
    internal class Program
    {
        public static async void Task1()
        {
           await Task.Run(() =>
            {
                Console.WriteLine("Task1 starting");
                Thread.Sleep(4000);
                Console.WriteLine("Task1 completed");
            });
           
        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task2 starting");
                Thread.Sleep(2000);
                Console.WriteLine("Task2 completed");

            });
            
        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task3 starting");
                Thread.Sleep(3000);
                Console.WriteLine("Task3 completed");
            });
            
        }
        public static async void Task4()
        {
           await Task.Run(()=>
            {
                Console.WriteLine("Task4 starting");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 completed");

            });
           
        }
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();


        }
    }
}
