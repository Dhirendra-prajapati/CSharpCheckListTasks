using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDbContext db=new MyDbContext();
            Programme p=new Programme();
            p.Id = 12;
            p.Title = "Bsc It";
            p.Duration = 3;
            p.Fees = 30000;
            db.Programmes.Add(p);
            db.SaveChanges();
            Console.WriteLine("data added successfully");
            Console.ReadLine();
        }
    }
}
