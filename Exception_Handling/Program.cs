using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"c:\file.zip");
                var content = streamReader.ReadToEnd();
                throw new Exception("Oops");

            }
            catch(Exception ex)
            {
                Console.WriteLine("Sorry, unexcepted error is occured");
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Dispose();
            }
            Console.ReadLine();
        }
    }
}
