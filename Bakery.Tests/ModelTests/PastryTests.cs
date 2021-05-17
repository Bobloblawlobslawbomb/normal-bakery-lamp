using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class PastryTests
  {

    [TestMethod]
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOfPastry_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.GetPrice();
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOf2Pastry_Int()
    {
      Pastry newPastry = new Pastry(2);
      int result = newPastry.GetPrice();
      Assert.AreEqual(4, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOf3Pastries_Int()
    {
      Pastry newPastry = new Pastry(3);
      int result = newPastry.GetPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOf4Pastries_Int()
    {
      Pastry newPastry = new Pastry(4);
      int result = newPastry.GetPrice();
      Assert.AreEqual(7, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOf6Pastries_Int()
    {
      Pastry newPastry = new Pastry(6);
      int result = newPastry.GetPrice();
      Assert.AreEqual(10, result);
    }
  }
}