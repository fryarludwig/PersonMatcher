
using PersonMatcher.Persons;

namespace PersonMatcher.Patterns
{
    class CasualMatchingPattern : MatchingPattern
    {
        public CasualMatchingPattern() : base("CasualPattern", 10)
        {
            // Nothing to see here
        }

        public override MATCH_RESULT CheckMatch(Person a, Person b)
        {
            if ((a.FirstName != null && b.FirstName != null && a.FirstName.Length > 0 && b.FirstName.Length > 0)
                && a.FirstName != b.FirstName
                && (a.LastName != null && b.LastName != null && a.LastName.Length > 0 && b.LastName.Length > 0)
                && a.LastName != b.LastName)
            {
                return MATCH_RESULT.NOT_EQUAL;
            }

            if (a.GetType().Equals(typeof(Adult)) && b.GetType().Equals(typeof(Adult)))
            {
                CasualMatchingAdult((Adult)a, (Adult)b);
            }
            else if (a.GetType().Equals(typeof(Child)) && b.GetType().Equals(typeof(Child)))
            {
                CasualMatchingChild((Child)a, (Child)b);
            }

            return MATCH_RESULT.INCONCLUSIVE;
        }

        protected MATCH_RESULT CasualMatchingAdult(Adult a, Adult b)
        {
            if (((Adult)a).Phone1 == ((Adult)b).Phone1 && ((Adult)b).Phone1 != null
                || ((Adult)a).Phone2 == ((Adult)b).Phone2 && ((Adult)b).Phone2 != null)
            {
                return MATCH_RESULT.EQUAL;
            }

            return MATCH_RESULT.INCONCLUSIVE;
        }

        protected MATCH_RESULT CasualMatchingChild(Child a, Child b)
        {
            int scoring = 0;

            if (a.BirthCounty != null && b.BirthCounty != null
                && (a.BirthCounty.Length > 0 && b.BirthCounty.Length > 0))
            {
                if (a.BirthCounty == b.BirthCounty)
                {
                    scoring++;
                }
                else
                {
                    scoring--;
                }
            }

            return MATCH_RESULT.INCONCLUSIVE;
        }
    }
}
