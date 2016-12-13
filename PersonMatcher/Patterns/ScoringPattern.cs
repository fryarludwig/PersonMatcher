using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using PersonMatcher.Persons;

namespace PersonMatcher.Patterns
{
    public class ScoringPattern : MatchingPattern
    {
        public ScoringPattern() : base("ScoringPattern", 5)
        {
            // Do nothing
        }

        public override MATCH_RESULT CheckMatch(Person a, Person b)
        {
            MATCH_RESULT returnValue = MATCH_RESULT.INCONCLUSIVE;

            PropertyInfo[] aPropertyInfo = a.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] bPropertyInfo = b.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance);

            object some_obj = new object();
            List<object> objList = new List<object>();

            foreach (PropertyInfo p in aPropertyInfo)
            {
                Logger.Trace(p.ToString());
                string name = p.Name;
                //var aVar = p.GetValue(some_obj, new object[10] { });
                //some_obj.ToString();
            }
            return returnValue;
        }
    }
}