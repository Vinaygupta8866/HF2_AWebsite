using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWebsiteDI
{
    abstract class Writer
    {
        public IReader Reader { get; private set; }
        public Writer(IReader Reader)
        {
            this.Reader = Reader;
        }
    }
}
