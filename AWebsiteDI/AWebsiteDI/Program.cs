using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWebsiteDI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name source:");

            IReader reader = Factory.GetReader(Console.ReadLine());
            IWriter writer = Factory.GetWriter(reader);
            writer.WriteOutput();

            Console.ReadKey();
        }
    }
}
