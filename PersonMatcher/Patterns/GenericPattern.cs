using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonMatcher.Persons;
using System.Reflection;

namespace PersonMatcher.Patterns
{
    public class GenericPattern : BasePattern
    {
        public GenericPattern() : base("GenericPattern", 5)
        {
            // Do nothing
        }

        protected override MATCH_RESULT InternalCompare(Person a, Person b)
        {
            MATCH_RESULT result = MATCH_RESULT.INCONCLUSIVE;
            int score = 0;
            IList<PropertyInfo> personProperties = new List<PropertyInfo>(typeof(Person).GetProperties());

            foreach (PropertyInfo prop in personProperties)
            {
                object valueA = prop.GetValue(a, null);
                object valueB = prop.GetValue(b, null);

                if (valueA != null && valueB != null)
                {
                    int weight = WeightMap[prop.Name];

                    if (valueA.GetType() == typeof(int))
                    {
                        score = ((int)valueA == (int)valueB) ? score += weight : score -= weight;
                    }
                    else if (valueA.GetType() == typeof(String) || valueA.GetType() == typeof(string))
                    {
                        String s1 = (String)valueA;
                        String s2 = (String)valueB;

                        if (PartialStringMatch(s1, s2))
                        {
                            score += weight;
                        }
                        else
                        {
                            score -= weight;
                        }
                    }
                }
            }
            
            if (score != 0)
            {
                result = (score > 0) ? MATCH_RESULT.EQUAL : MATCH_RESULT.NOT_EQUAL;
            }

            return result;
        }

    }
}
