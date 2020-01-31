using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWebsiteDI
{
    abstract class Reader
    {
        public string NameOfSource { get; private set; }
        protected Reader(string NameOfSource)
        {
            this.NameOfSource = NameOfSource;
        }
    }
}
