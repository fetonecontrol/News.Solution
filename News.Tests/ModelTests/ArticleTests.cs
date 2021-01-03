using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using News.Solution.Models;
using System;

namespace News.Tests
{
  [TestClass]
  public class ArticleTests
  {
    [TestMethod]
    public void DoesApiCallReturnJsonData()
    {
      var allArticles = Article.GetNYT();
      Console.WriteLine(allArticles);
      Assert.AreEqual(true, allArticles);
    }
  }
}