using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWebsiteDI
{
    class ReaderFile : Reader, IReader
    {
        public ReaderFile(string NameOfSource) : base(NameOfSource) { }

        public string GetRespone()
        {
            string respone = File.ReadAllText(NameOfSource);
            return respone;
        }
    }
}
