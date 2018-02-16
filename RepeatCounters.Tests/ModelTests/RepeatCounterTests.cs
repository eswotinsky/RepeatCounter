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

        [TestMethod]
        public void FindRepeats_InputIsMultipleChar_True()
        {
            RepeatCounter testCounter = new RepeatCounter("am", "I am the walrus");
            Assert.AreEqual(1, testCounter.FindRepeats());
        }

        [TestMethod]
        public void FindRepeats_MatchesAreCaseInsensitive_True()
        {
            RepeatCounter testCounter = new RepeatCounter("i", "I am the walrus");
            Assert.AreEqual(1, testCounter.FindRepeats());
        }

        [TestMethod]
        public void FindRepeats_InputMatchesOnlyWholeWords_True()
        {
            RepeatCounter testCounter = new RepeatCounter("the", "Bring the thesaurus to the bookshelf");
            Assert.AreEqual(2, testCounter.FindRepeats());
        }
    }
}
