using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bakery.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bakery.Tests.ModelTests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreateAndInstanceOfPastry_Pastry()
    {
      Pastry pastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_CreateAndInstanceOfPastryWithoutPassingAnArgument_Pastry()
    {
      Pastry pastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void PastryConstructor_AssignUserInputAsLoafQuantity_Int()
    {
      int userInput = 2;
      Pastry pastry = new Pastry(userInput);
      Assert.AreEqual(userInput, pastry.Qty);
    }

    [TestMethod]
    public void GetNormalPrice_ReturnNormalCostOfPastryBasedOnQty_Int() {
      int userInput = 1;
      int price = 2;
      Pastry pastry = new Pastry(userInput);
      Assert.AreEqual(price, pastry.GetNormalPrice(pastry.Qty));
      pastry.Qty = 2;
      price = 4;
      Assert.AreEqual(price, pastry.GetNormalPrice(pastry.Qty));
    }

    [TestMethod]
    public void GetDiscountPrice_ReturnDiscountedCostOfPastryAtFiveInEveryThreeQty_Int() {
      int userInput = 3;
      int price = 5;
      Pastry pastry = new Pastry(userInput);
      Assert.AreEqual(price, pastry.GetDiscountPrice());
      pastry.Qty = 7;
      price = 10;
      Assert.AreEqual(price, pastry.GetDiscountPrice());
    }

    [TestMethod]
    public void GetTotalCost_ReturnTotalCostBasedOnDiscountPriceAndNormalPrice_Int() {
      int userInput = 2;
      int price = 4;
      Pastry pastry = new Pastry(userInput);
      Assert.AreEqual(price, pastry.GetTotalCost());
      pastry.Qty = 5;
      price = 9;
      Assert.AreEqual(price, pastry.GetTotalCost());
      pastry.Qty = 6;
      price = 10;
      Assert.AreEqual(price, pastry.GetTotalCost());
    }
  }
}