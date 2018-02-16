using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatCounter.Models;

namespace RepeatCounter.TestTools
{
    [TestClass]
    public class RepeatCounterTest
    {
        [TestMethod]
        public void FindRepeats_InputIsSingleChar_True()
        {
            RepeatCounter testCounter = new RepeatCounter("I", "I am the walrus");
            Assert.AreEqual(1, testCounter.FindRepeats());
        }
    }
}
