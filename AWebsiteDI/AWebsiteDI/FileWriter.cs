using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWebsiteDI
{
    class FileWriter : Writer, IWriter
    {
        public FileWriter(IReader Reader) : base(Reader) { }

        public void WriteOutput()
        {
            string path = @"c:\temp\MyTest.txt";

            // Create a file to write to.
            File.WriteAllText(path, Reader.GetRespone(), Encoding.UTF8);
            

            Console.WriteLine("File created!");
        }
    }
}
