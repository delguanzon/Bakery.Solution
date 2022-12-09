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
      // any necessary logic to prep for test; instantiating new classes, etc.
      Bread bread = new Bread();
      Assert.AreEqual(typeof(Bread), bread.GetType());
    }

    public void BreadConstructor_AssignUserInputAsLoafQuantity_Bread()
    {
      // any necessary logic to prep for test; instantiating new classes, etc.
      int userInput = 2;
      Bread bread = new Bread(2);
      Assert.AreEqual(userInput, Bread.LoafQty);
    }

  }
}