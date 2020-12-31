using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace News.Solution.Models
{
  public class Article
  {
    public string Section { get; set; }
    public string Title { get; set; }
    public string Abstract { get; set; }
    public string Url { get; set; }
    public string Byline { get; set; }

    public Article(string section, string title, string url, string byline)    
    {
      Section = section;
      Title = title;
      Abstract = abstract;
      Url = url;
      Byline = byline;
    }

    public static List<Article> GetArticles()
    {
      var apiCallTask = NYTApiCall.ApiCall();
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Article> articleList = JsonConvert.DeserializeObject<List<Article>>(jsonResponse["results"].ToString());

      return articleList;
    }
  }
}