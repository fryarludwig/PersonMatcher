
using PersonMatcher.Persons;
using System.Linq;

namespace PersonMatcher.Patterns
{
    public class LegalIdPattern : BasePattern
    {
        public LegalIdPattern() : base("LegalPattern", 9)
        {
            // Nothing to see here
        }

        protected override MATCH_RESULT InternalCompare(Person a, Person b)
        {
            string sfn1 = (a.StateFileNumber != null) ? new string(a.StateFileNumber.Where(c => char.IsDigit(c)).ToArray()) : "";
            string sfn2 = (b.StateFileNumber != null) ? new string(b.StateFileNumber.Where(c => char.IsDigit(c)).ToArray()) : "";
            string ssn1 = (a.SocialSecurityNumber != null) ? new string(a.SocialSecurityNumber.Where(c => char.IsDigit(c)).ToArray()) : "";
            string ssn2 = (b.SocialSecurityNumber != null) ? new string(b.SocialSecurityNumber.Where(c => char.IsDigit(c)).ToArray()) : "";

            if (sfn1.Length > 0 && sfn2.Length > 0)
            {
                if (PartialStringMatch(sfn1, sfn2))
                {
                    return MATCH_RESULT.EQUAL;
                }
                else
                {
                    return MATCH_RESULT.NOT_EQUAL;
                }
            }

            if (ssn1.Length > 0 && ssn2.Length > 0)
            {
                if (PartialStringMatch(ssn1, ssn2))
                {
                    return MATCH_RESULT.EQUAL;
                }
                else
                {
                    return MATCH_RESULT.NOT_EQUAL;
                }
            }

            return MATCH_RESULT.INCONCLUSIVE;
        }
    }
}
