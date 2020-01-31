using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWebsiteDI
{
    static class Factory
    {
        public static IReader GetReader(string sourceName)
        {
            //https://youtube.com
            //C:\Users\bto\Documents\856108818790623675OIS199PF.txt
            return new ReaderURL(sourceName);
        }
        public static IWriter GetWriter(IReader reader)
        {
            return new FileWriter(reader);
        }
    }
}
