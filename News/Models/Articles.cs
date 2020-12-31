using System;

namespace News.Solution.Models
{
  public class Article
  {
    public int ArticleId { get; set; }
    // public DateTime Date { get; set; }
    public string Title { get; set; }
    public string Abstract { get; set; }
    public string Body { get; set; }
  }

}