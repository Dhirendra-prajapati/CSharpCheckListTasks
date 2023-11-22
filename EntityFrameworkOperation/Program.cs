using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (DemoContext context = new DemoContext())
            {

                //Product shirt = new Product()
                //{
                //    Name = "Polo T-shirt",
                //    Price = 300
                //};
                //context.Products.Add(shirt);
                //Product pant = new Product()
                //{
                //    Name = "Pant",
                //    Price = 500
                //};
                //context.Products.Add(pant);
                //context.SaveChanges();
                var tshirt = context.Products.FirstOrDefault(Product =>Product.Name== "Polo T-shirt");
                if (tshirt != null)
                    tshirt.Price = 600;
                context.SaveChanges();
                var Products = context.Products.Where(Product => Product.Price > 200).OrderBy(Product => Product.Name).ToList();

                foreach (var Product in Products)
                {
                    Console.WriteLine($"Id:{Product.Id}");
                    Console.WriteLine($"Name:{Product.Name}");
                    Console.WriteLine($"Price : {Product.Price}");
                    Console.WriteLine("----------------------");
                }
                Console.ReadLine();
            }
        }
    }
}
