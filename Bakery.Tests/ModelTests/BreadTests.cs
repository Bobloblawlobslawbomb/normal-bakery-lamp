using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;

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
    public void PastryConstructor_CreatesInstanceOfPastry_Pastry()
    {
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOfBread_Int()
    {
      Bread newBread = new Bread(1);
      int result = newBread.GetPrice();
      Assert.AreEqual(5, newBread.GetPrice());
    }

    [TestMethod]
    public void GetPrice_ReturnPriceOfPastry_Int()
    {
      Pastry newPastry = new Pastry(1);
      int result = newPastry.GetPrice();
      Assert.AreEqual(2, newPastry.GetPrice());
    }

    [TestMethod]
    public void GetPrice_MultiplyBreadPricebyBreadQuantity_Int()
    {
      Bread newBread = new Bread(2);
      int result = newBread.GetPrice();
      Assert.AreEqual(10, newBread.GetPrice());
    }

    [TestMethod]
    public void GetPrice_Pastry2For3DollarDeal_Int()
    {
      Pastry newPastry = new Pastry(2);
      int result = newPastry.GetPrice();
      Assert.AreEqual(3, newPastry.GetPrice());
    }
  }
}

// Test boilerplate
// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }

// Arrange
// Act
// Assert