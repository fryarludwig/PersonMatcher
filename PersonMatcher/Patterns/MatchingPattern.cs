using System;

using PersonMatcher.Persons;
using PersonMatcher.IO;

namespace PersonMatcher.Patterns
{
    public abstract class MatchingPattern
    {
        public MatchingPattern(String handlerName, int filterWeight)
        {
            PatternName = handlerName;
            Logger = new LogUtility(handlerName);
            FilterWeight = filterWeight;
        }

        public abstract MATCH_RESULT CheckMatch(Person a, Person b);
        
        public enum MATCH_RESULT
        {
            NOT_EQUAL = -1,
            INCONCLUSIVE = 0,
            EQUAL = 1
        }

        protected LogUtility Logger;
        public String PatternName { get; }
        // Filter Weight is used to sort through the values in a specified order
        public int FilterWeight { get; }
    }
}
