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
    public void BreadConstructor_CreateAndInstanceOfBread_Bread()
    {
      Pastry pastry = new Pastry(2);
      Assert.AreEqual(typeof(Pastry), pastry.GetType());
    }

    [TestMethod]
    public void BreadConstructor_AssignUserInputAsLoafQuantity_Int()
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
      Assert.AreEqual(price, pastry.GetNormalPrice());
      pastry.Qty = 2;
      price = 4;
      Assert.AreEqual(price, pastry.GetNormalPrice());
    }

    
  }
}