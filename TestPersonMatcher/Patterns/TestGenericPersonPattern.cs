using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;
using System.Collections.Generic;
using System.Reflection;

namespace TestPersonMatcher.Patterns
{
    [TestClass]
    public class TestGenericPersonPattern
    {
        [TestMethod]
        public void TestEmptyPersons()
        {
            Person a = new Adult();
            Person b = new Child();
            GenericPattern pattern = new GenericPattern();
            Assert.AreEqual(BasePattern.MATCH_RESULT.INCONCLUSIVE, pattern.Compare(a, b));

            a.BirthDay = 3;
            b.BirthDay = 3;

            Assert.AreEqual(BasePattern.MATCH_RESULT.EQUAL, pattern.Compare(a, b));

            a.BirthDay = null;
            b.BirthDay = null;
            a.FirstName = "Tim";
            b.FirstName = "Timothy";

            Assert.AreEqual(BasePattern.MATCH_RESULT.EQUAL, pattern.Compare(a, b));
        }

        [TestMethod]
        public void TestGenericMatches()
        {
            GenericPattern pattern = new GenericPattern();
            Assert.IsTrue(pattern.CanHandleType(typeof(Adult)));
            Assert.IsTrue(pattern.CanHandleType(typeof(Child)));
            Assert.AreEqual(pattern.Compare(new Child(), new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Adult(), new Child()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Child(), new Adult()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            Assert.AreEqual(pattern.Compare(new Adult(), new Adult()), BasePattern.MATCH_RESULT.INCONCLUSIVE);
            
            Assert.AreEqual(pattern.Compare(TVars.Slim1, TVars.Slim2), BasePattern.MATCH_RESULT.EQUAL);
            Assert.AreEqual(pattern.Compare(TVars.Slim1, TVars.NotSlim), BasePattern.MATCH_RESULT.NOT_EQUAL);
            Assert.AreEqual(pattern.Compare(TVars.Slim1, TVars.Abram3), BasePattern.MATCH_RESULT.NOT_EQUAL);
            Assert.AreEqual(pattern.Compare(TVars.Slim2, TVars.NotSlim), BasePattern.MATCH_RESULT.NOT_EQUAL);
            Assert.AreEqual(pattern.Compare(TVars.Slim2, TVars.Abram3), BasePattern.MATCH_RESULT.NOT_EQUAL);
        }
    }
}
