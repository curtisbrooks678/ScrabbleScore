using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScrabbleTime.Models;

namespace ScrabbleTime.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void Score_ReturnsInt_int()
    {
      Assert.AreEqual(typeof(int), Game.Score("T").GetType());
    }

    [TestMethod]
    public void Score_ReturnPointValueForSingleChar_int()
    {
      Assert.AreEqual(5, Game.Score("K"));
    }
  }
}
