using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;

namespace TestPersonMatcher.Persons
{
    [TestClass]
    public class TestMatchResult
    {
        [TestMethod]
        public void TestMatchResultConstructor()
        {
            Adult adult = new Adult();
            Child child = new Child();
            MatchResult result = new MatchResult(adult, child);
            Assert.AreEqual(result.Person1.GetType(), typeof(Adult));
            Assert.AreEqual(result.Person2.GetType(), typeof(Child));
            Assert.IsTrue(result.ToString().Length > 0);
        }
    }
}
