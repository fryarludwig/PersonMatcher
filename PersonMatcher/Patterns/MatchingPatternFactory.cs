using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace PersonMatcher.Patterns
{
    public static class MatchingPatternFactory
    {
        static MatchingPatternFactory() { }

        public static List<MatchingPattern> GetSortedPatterns(params object[] constructorArgs)
        {
            List<MatchingPattern> objectList = new List<MatchingPattern>();
            foreach (Type type in Assembly.GetAssembly(typeof(MatchingPattern)).GetTypes().Where(myType => myType.IsClass 
            && !myType.IsAbstract 
            && myType.IsSubclassOf(typeof(MatchingPattern))))
            {
                objectList.Add((MatchingPattern)Activator.CreateInstance(type, constructorArgs));
            }
            
            return objectList.OrderBy(o => o.FilterWeight).ToList(); 
        }
    }
}
