using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;

namespace TestPersonMatcher.Patterns
{
    [TestClass]
    public class TestAdultPattern
    {
        [TestMethod]
        public void TestAdultPatternMatching()
        {
            AdultPattern pattern = new AdultPattern();
            Assert.IsTrue(pattern.CanHandleType(typeof(Adult)));
            Assert.IsFalse(pattern.CanHandleType(typeof(Child)));
            Assert.AreEqual(pattern.Compare(new Child(), new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Adult(), new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Child(), new Adult()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Adult(), new Adult()), BasePattern.MATCH_RESULT.INCONCLUSIVE);

            Person p1 = TVars.Slim1;
            Person p2 = TVars.Slim2;
            Person p3 = TVars.NotSlim;
            Person p4 = TVars.Abram3;

            Assert.AreEqual(pattern.Compare(p1, p2), BasePattern.MATCH_RESULT.EQUAL);
            Assert.AreEqual(pattern.Compare(p1, p3), BasePattern.MATCH_RESULT.NOT_EQUAL);
            Assert.AreEqual(pattern.Compare(p1, p4), BasePattern.MATCH_RESULT.NOT_EQUAL);
            Assert.AreEqual(pattern.Compare(p2, p3), BasePattern.MATCH_RESULT.NOT_EQUAL);
            Assert.AreEqual(pattern.Compare(p2, p4), BasePattern.MATCH_RESULT.NOT_EQUAL);
        }
    }
}
