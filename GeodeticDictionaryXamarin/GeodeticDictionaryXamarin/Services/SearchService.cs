using System;
using System.Net.Http;
using System.Threading.Tasks;
using GeodeticDictionaryXamarin.Exception;
using Newtonsoft.Json;

namespace GeodeticDictionaryXamarin
{
    public class SearchService
    {
        public async Task<TranslationsDto> GetTranslationsAsync(string text)
        {
            using (var httpClient = EasyHttpClient.CreateClient())
            {
                var options = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri =
                        new Uri(
                            "https://dictionary.search.windows.net/indexes/translations/docs?api-version=2015-02-28" +
                            $"&queryType=simple&searchFields=german&search={text}*&searchMode=all")
                };
                options.Headers.Add("Api-Key", "[api key]");

                var response = await httpClient.SendAsync( options ).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
                    if (!string.IsNullOrWhiteSpace(json))
                        return await Task.Run(() =>
                            JsonConvert.DeserializeObject<TranslationsDto>(json)
                        ).ConfigureAwait(false);

                    return new TranslationsDto();
                }
                throw new HttpClientError(response.StatusCode);
            }
        }
    }
}