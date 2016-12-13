using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;

namespace TestPersonMatcher
{
    [TestClass]
    public class TestMatchWorker
    {
        [TestMethod]
        public void TestMatcherConstructor()
        {
            MatchMaker matcher = new MatchMaker();
            Assert.IsNotNull(matcher);
            Assert.AreEqual(matcher.Matches.Count, 0);
            Assert.AreEqual(matcher.Persons.Count, 0);
        }
    }
}
