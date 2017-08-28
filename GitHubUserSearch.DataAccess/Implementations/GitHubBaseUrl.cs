using GitHubUserSearch.DataAccess.Interfaces;
using System.Net.Http;
using System.Net.Http.Headers;

namespace GitHubUserSearch.DataAccess.Implementations
{
    public class GitHubBaseUrl : IBaseUrl
    {
       public string BaseUrl(string url)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var responseMsg = client.GetAsync(url).Result;

                return responseMsg.IsSuccessStatusCode ? responseMsg.Content.ReadAsStringAsync().Result : string.Empty;
            }
        }
    }
}