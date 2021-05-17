using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {

    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOfBread_Int()
    {
      Bread newBread = new Bread(1);
      int result = newBread.GetPrice();
      Assert.AreEqual(5, result);
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOf4Bread_Int()
    {
      Bread newBread = new Bread(4);
      int result = newBread.GetPrice();
      Assert.AreEqual(20, result);
    }

    [TestMethod]
    public void BreadDeal_ReturnNewBreadDealQuantity_Int()
    {
      Bread newBread = new Bread(2);
      int result = newBread.BreadDeal();
      Assert.AreEqual(3, result);
    }

    [TestMethod]
    public void BreadDeal_ReturnNewBreadDealForQuantity4_Int()
    {
      Bread newBread = new Bread(4);
      int result = newBread.BreadDeal();
      Assert.AreEqual(6, result);
    }
  }
}
