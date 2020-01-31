using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AWebsiteDI
{
    class ReaderURL : Reader, IReader
    {
        public ReaderURL(string NameOfSource) : base(NameOfSource) { }

        public string GetRespone()
        {  
            WebRequest request = WebRequest.Create(this.NameOfSource);
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.  
            WebResponse response = request.GetResponse();

            using (Stream dataStream = response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string responseFromServer = reader.ReadToEnd();
                response.Close();
                return responseFromServer;
            }
            
        }
    }
}
