using System;
using System.Threading.Tasks;
using RestSharp;

namespace News.Solution.Models 
{
  public class NYTApiCall {
    public static async Task<string> ApiCall()
    {
      RestClient client = new RestClient("https://api.nytimes.com/svc/topstories/v2");
      RestRequest request = new RestRequest($"home.json?api-key={EnvironmentVariables.apiKey}", Method.GET);
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}