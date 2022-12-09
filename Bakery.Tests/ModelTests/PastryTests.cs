using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
  }
}