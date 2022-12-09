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
    public void GetCost_ReturnCostBasedOnLoafQty_Int() {
      int userInput = 2;
      Bread bread = new Bread(userInput);
      Assert.AreEqual(10, bread.GetCost());
    }

    [TestMethod]
    public void GetDiscount_ReturnDiscountValueBasedOnLoafQty_Int() {
      int userInput = 3;
      Bread bread = new Bread(userInput);
      Assert.AreEqual(5, bread.GetDiscount());
      bread.LoafQty = 5;
      Assert.AreEqual(5, bread.GetDiscount());
      bread.LoafQty = 9;
      Assert.AreEqual(15, bread.GetDiscount());
    }

    [TestMethod]
    public void GetCost_ReturnCostBasedOnLoafQtyAndApplyingTheDiscount_Int() {
      int userInput = 2;
      Bread bread = new Bread(userInput);
      Assert.AreEqual(10, bread.GetCost());
      bread.LoafQty = 5;
      Assert.AreEqual(20, bread.GetCost());
      bread.LoafQty = 9;
      Assert.AreEqual(30, bread.GetCost());
    }
  }
}