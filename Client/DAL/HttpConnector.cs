using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Client.DAL
{
    class HttpConnector : HttpClient
    {
        String BASE_URL = "http://localhost:64924/";
        public HttpConnector()
        {
            BaseAddress = new Uri(BASE_URL);
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add
                (new MediaTypeWithQualityHeaderValue("text/html"));
        }
        

    }
}
