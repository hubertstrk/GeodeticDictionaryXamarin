using System;
using System.Net.Http;
using System.Net.Http.Headers;
using ModernHttpClient;

namespace GeodeticDictionaryXamarin
{
    public static class EasyHttpClient
    {
        public static HttpClient CreateClient()
        {
            var nativeHandler = new NativeMessageHandler();
            var httpClient = new HttpClient( nativeHandler );
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add( new MediaTypeWithQualityHeaderValue( "application/json" ) );

            return httpClient;
        }
    }
}
