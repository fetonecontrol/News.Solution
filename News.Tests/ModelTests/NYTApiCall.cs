using Microsoft.VisualStudio.TestTools.UnitTesting;
using News.Solution.Models;
using System;

namespace News.Tests
{
  [TestClass]
  public class NYTApiCallTests
  {
    [TestMethod]
    public void DoesApiCallReturnJsonData()
    {
      NYTApiCall apiCall = new NYTApiCall();
      System.WriteLine(apiCall);
      Assert.AreEqual(true, apiCall);
    }
  }
}