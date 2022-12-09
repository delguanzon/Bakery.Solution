using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;

namespace Bakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreateAndInstanceOfBread_Bread()
    {
      Bread bread = new Bread(2);
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AssignUserInputAsLoafQuantity_Int()
    {
      int userInput = 2;
      Bread bread = new Bread(userInput);
      Assert.AreEqual(userInput, bread.LoafQty);
    }

    [TestMethod]
    public void GetCost_ReturnCostBasedOnLoafQty_Ten() {
      int userInput = 2;
      Bread bread = new Bread(userInput);
      Assert.AreEqual(10, bread.GetCost());
    }

  }
}