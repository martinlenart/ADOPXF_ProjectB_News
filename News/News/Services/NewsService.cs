//#define UseNewsApiSample  // Remove or undefine to use your own code to read live data

using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Collections.Concurrent;
using System.Threading.Tasks;

using News.Models;
using News.ModelsSampleData;

namespace News.Services
{
    public class NewsService
    {

        //Here is where you lift in your Service code from Part A
/*
        public async Task<NewsGroup> GetNewsAsync(NewsCategory category)
        {

#if UseNewsApiSample      
            NewsApiData nd = await NewsApiSampleData.GetNewsApiSampleAsync(category);

#else
            //https://newsapi.org/docs/endpoints/top-headlines
            var uri = $"https://newsapi.org/v2/top-headlines?country=se&category={category}&apiKey={apiKey}";


            //Recommend to use Newtonsoft Json Deserializer as it works best with Android
            var webclient = new WebClient();
            var json = await webclient.DownloadStringTaskAsync(uri);
            NewsApiData nd = Newtonsoft.Json.JsonConvert.DeserializeObject<NewsApiData>(json);

#endif
*/
    }
}
