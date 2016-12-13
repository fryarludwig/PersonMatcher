using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;
using System.Collections.Generic;

namespace TestPersonMatcher.Patterns
{
    [TestClass]
    public class TestMatchingPatternFactory
    {
        [TestMethod]
        public void TestPatternFactory()
        {
            List<BasePattern> patterns = new List<BasePattern>();
            Assert.AreEqual(patterns.Count, 0);

            patterns = MatchingPatternFactory.GetSortedPatterns();
            Assert.IsNotNull(patterns);
            Assert.AreEqual(patterns.Count, 5);

            foreach (BasePattern p in patterns)
            {
                Assert.IsNotNull(p);
            }

            patterns.Clear();
            Assert.AreEqual(patterns.Count, 0);
            patterns = MatchingPatternFactory.GetSortedPatterns(typeof(Adult));
            Assert.IsNotNull(patterns);
            Assert.AreEqual(patterns.Count, 4);

            foreach (BasePattern p in patterns)
            {
                Assert.IsNotNull(p);
            }
            
            patterns.Clear();
            Assert.AreEqual(patterns.Count, 0);
            patterns = MatchingPatternFactory.GetSortedPatterns(typeof(Child));
            Assert.IsNotNull(patterns);
            Assert.AreEqual(patterns.Count, 4);

            foreach (BasePattern p in patterns)
            {
                Assert.IsNotNull(p);
            }
        }
    }
}
