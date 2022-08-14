//#define UseNewsApiSample  // Remove or undefine to use your own code to read live data

using News.Models;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json; //Requires nuget package System.Net.Http.Json
using System.Threading.Tasks;

namespace News.Services
{
    public class NewsService
    {

        //Here is where you lift in your Service code from Part A

        HttpClient httpClient;
        readonly string apiKey = "d318329c40734776a014f9d9513e14ae";

        public NewsService()
        {
            httpClient = new HttpClient(new HttpClientHandler { AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate });
            httpClient.DefaultRequestHeaders.Add("user-agent", "News-API-csharp/0.1");
            httpClient.DefaultRequestHeaders.Add("x-api-key", apiKey);
        }

        /*
        public async Task<NewsGroup> GetNewsAsync(NewsCategory category)
        {

#if UseNewsApiSample
            NewsApiData nd = await NewsApiSampleData.GetNewsApiSampleAsync(category);

#else
            var uri = $"https://newsapi.org/v2/top-headlines?country=se&category={category}";

            // make the http request
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, uri);
            var response = await httpClient.SendAsync(httpRequest);
            response.EnsureSuccessStatusCode();

            //Convert Json to Object
            NewsApiData nd = await response.Content.ReadFromJsonAsync<NewsApiData>();

#endif
            //Here must be code to convert from NewsApiData to NewsGroup
        }
        */
    }
}
