using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akavache;

namespace GeodeticDictionaryXamarin
{
    public static class Cache
    {
        public static void Initialize(Func<string> func)
        {
            BlobCache.ApplicationName = func();
        }

        public static async Task ShutdownAsync()
        {
            await BlobCache.Shutdown();
        }
    }
}
