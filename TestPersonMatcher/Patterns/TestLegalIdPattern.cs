using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;

namespace TestPersonMatcher.Patterns
{
    [TestClass]
    public class TestLegalIdPattern
    {
        [TestMethod]
        public void TestIdMatching()
        {
            LegalIdPattern pattern = new LegalIdPattern();
            Assert.IsTrue(pattern.CanHandleType(typeof(Adult)));
            Assert.IsTrue(pattern.CanHandleType(typeof(Child)));
            Assert.AreEqual(pattern.Compare(new Child(), new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Adult(), new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Child(), new Adult()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Adult(), new Adult()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(TVars.Tim1, TVars.Tim2), BasePattern.MATCH_RESULT.EQUAL);
            Assert.AreEqual(pattern.Compare(TVars.Tim1, TVars.NotSlim), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(TVars.Tim1, TVars.TimsFakeId), BasePattern.MATCH_RESULT.NOT_EQUAL);
            Assert.AreEqual(pattern.Compare(TVars.Tim2, TVars.NotSlim), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(TVars.Tim2, TVars.TimsFakeId), BasePattern.MATCH_RESULT.NOT_EQUAL);
        }
    }
}
