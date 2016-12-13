using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;

namespace TestPersonMatcher.Patterns
{
    [TestClass]
    public class TestChildPattern
    {
        [TestMethod]
        public void TestChildMatching()
        {
            ChildPattern pattern = new ChildPattern();
            Assert.IsFalse(pattern.CanHandleType(typeof(Adult)));
            Assert.IsTrue(pattern.CanHandleType(typeof(Child)));
            Assert.AreEqual(pattern.Compare(new Child(), new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Adult(), new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Child(), new Adult()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Adult(), new Adult()), BasePattern.MATCH_RESULT.INCONCLUSIVE);

            Person p1 = TVars.Slim1;
            Person p2 = TVars.Slim2;
            Person p4 = TVars.Abram3;

            Assert.AreEqual(pattern.Compare(p1, p4), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(p2, p4), BasePattern.MATCH_RESULT.INCONCLUSIVE);

            Child c1 = (Child)TVars.Abram1;
            Child c2 = (Child)TVars.Abram2;
            Assert.AreEqual(pattern.Compare(c1, new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(c1, c2), BasePattern.MATCH_RESULT.EQUAL);
            Assert.AreEqual(pattern.Compare(c2, p4), BasePattern.MATCH_RESULT.INCONCLUSIVE);
        }
    }
}
