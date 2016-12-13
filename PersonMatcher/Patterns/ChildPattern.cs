
using PersonMatcher.Persons;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace PersonMatcher.Patterns
{
    public class ChildPattern : BasePattern
    {
        public ChildPattern() : base("ChildPattern", 4, typeof(Child))
        {
        }

        protected override MATCH_RESULT InternalCompare(Person a, Person b)
        {
            Child p1 = (Child)a;
            Child p2 = (Child)b;
            int score = 0;

            IList<PropertyInfo> childFields = new List<PropertyInfo>(typeof(Child).GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance));

            foreach (PropertyInfo prop in childFields)
            {
                object valueA = prop.GetValue(p1, null);
                object valueB = prop.GetValue(p2, null);

                if (valueA != null && valueB != null)
                {
                    if (valueA.GetType() == typeof(int))
                    {
                        score += ((int)valueA == (int)valueB) ? WeightMap[prop.Name] : -1 * WeightMap[prop.Name];
                    }
                    else if (valueA.GetType() == typeof(String) || valueA.GetType() == typeof(string))
                    {
                        score += (PartialStringMatch((String)valueA, (String)valueB))? WeightMap[prop.Name] : -1 * WeightMap[prop.Name];
                    }
                }
            }

            if (score != 0)
            {
                return (score > 0) ? MATCH_RESULT.EQUAL : MATCH_RESULT.NOT_EQUAL;
            }
            
            return MATCH_RESULT.INCONCLUSIVE;
        }
    }
}
