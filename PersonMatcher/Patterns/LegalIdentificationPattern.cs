
using PersonMatcher.Persons;

namespace PersonMatcher.Patterns
{
    class LegalIdentificationPattern : MatchingPattern
    {
        public LegalIdentificationPattern() : base("LegalIdentityPattern", 1)
        {
            // Nothing to see here
        }

        public override MATCH_RESULT CheckMatch(Person a, Person b)
        {
            if (a.GetType().Equals(typeof(Child)) && b.GetType().Equals(typeof(Child)))
            {
                Child child1 = (Child)a;
                Child child2 = (Child)b;
                if (child1.NewbornScreeningNumber != null && child2.NewbornScreeningNumber != null
                && child1.NewbornScreeningNumber.Length > 0 && child2.NewbornScreeningNumber.Length > 0)
                {
                    if (child1.NewbornScreeningNumber == child2.NewbornScreeningNumber)
                    {
                        return MATCH_RESULT.EQUAL;
                    }
                }
            }

            if (a.SocialSecurityNumber != null && b.SocialSecurityNumber != null
            && a.SocialSecurityNumber.Length > 0 && b.SocialSecurityNumber.Length > 0)
            {
                if (a.SocialSecurityNumber == b.SocialSecurityNumber)
                {
                    return MATCH_RESULT.EQUAL;
                }

                return MATCH_RESULT.NOT_EQUAL;
            }

            if (a.StateFileNumber != null && b.StateFileNumber != null
                && a.StateFileNumber.Length > 0 && b.StateFileNumber.Length > 0)
            {
                if (a.StateFileNumber == b.StateFileNumber)
                {
                    return MATCH_RESULT.EQUAL;
                }

                return MATCH_RESULT.NOT_EQUAL;
            }

            return MATCH_RESULT.INCONCLUSIVE;
        }
    }
}
