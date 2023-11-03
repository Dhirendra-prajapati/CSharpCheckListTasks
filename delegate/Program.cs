using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class Book
    {
        public String Title { get; set; }
        public float price { get; set; }
    }
    public class BookRepository
    {
        public IEnumerable<Book> GetBook()
        {
            return new List<Book>
            {
                new Book(){Title="Ado.Net step by step",price=9.99f},
                new Book(){Title="ASp.Net ",price=8f},
                new Book(){Title="C#",price=9f},
                new Book(){Title=".Net Core",price=12.6f},
                new Book(){Title=".Net Core",price=15.6f}

            };
        }

    }
  
    internal class Program
    {
        static void Main(string[] args)
        {
        var books=new BookRepository().GetBook();
            var cheapBooks = new List<Book>();
            foreach (var book in books)
                if (book.price < 10)
                    cheapBooks.Add(book);
            //var cheapBooks = books.
            //                       Where(b => b.price < 10)
            //                       .OrderBy(b => b.Title)
            //                       .Select(b => b.Title);
            var count = books.Max(b=>b.price);
            var min = books.Min(b => b.price);
            var sumof = books.Sum(b => b.price);
            Console.WriteLine(count);
            Console.WriteLine(min);
            Console.WriteLine(sumof);



            Console.ReadLine();
        }
    }
}
