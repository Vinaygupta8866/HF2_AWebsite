using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWebsiteDI
{
    class ConsoleWriter : Writer, IWriter
    {
        public ConsoleWriter(IReader Reader) : base(Reader) { }

        public void WriteOutput()
        {
            Console.WriteLine("Respone is:");
            Console.WriteLine();
            Console.WriteLine(Reader.GetRespone());
        }
    }
}
