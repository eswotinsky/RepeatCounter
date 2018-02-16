using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepeatCounters.Models;

namespace RepeatCounters.TestTools
{
    [TestClass]
    public class RepeatCountersTest
    {
        [TestMethod]
        public void FindRepeats_InputIsSingleChar_True()
        {
            RepeatCounter testCounter = new RepeatCounter("I", "I am the walrus");
            Assert.AreEqual(1, testCounter.FindRepeats());
        }
    }
}
