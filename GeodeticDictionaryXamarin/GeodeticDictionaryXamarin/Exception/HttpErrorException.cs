using System;
using System.Net;

namespace GeodeticDictionaryXamarin.Exception
{
    public class HttpClientError : System.Exception
    {
        public HttpStatusCode StatusCode { get; set; }

        public HttpClientError(HttpStatusCode statusCode) : base("HttpClient error")
        {
            StatusCode = statusCode;
        }
    }
}
