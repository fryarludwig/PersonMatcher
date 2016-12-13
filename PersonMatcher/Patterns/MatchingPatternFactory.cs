using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PersonMatcher.Patterns
{
    public static class MatchingPatternFactory
    {
        static MatchingPatternFactory() { }

        public static List<BasePattern> GetSortedPatterns(Type forceType = null)
        {
            List<BasePattern> patternList = new List<BasePattern>();
            foreach (Type type in Assembly.GetAssembly(typeof(BasePattern)).GetTypes().Where(myType => myType.IsClass 
                && !myType.IsAbstract && myType.IsSubclassOf(typeof(BasePattern))))
            {
                BasePattern pattern = (BasePattern)Activator.CreateInstance(type, null);
                if (pattern.CanHandleType(forceType))
                {
                    patternList.Add(pattern);
                }
            }

            return patternList.OrderBy(o => o.Weight).ToList();
        }
    }
}
