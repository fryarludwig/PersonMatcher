using System.Reflection;
using System.Linq;

using PersonMatcher.Persons;
using System.Collections.Generic;
using System;

namespace PersonMatcher.Patterns
{
    public class AdultPattern : BasePattern
    {
        public AdultPattern() : base("AdultPattern", 4, typeof(Adult))
        {

        }

        protected override MATCH_RESULT InternalCompare(Person a, Person b)
        {
            MATCH_RESULT result = MATCH_RESULT.INCONCLUSIVE;
            Adult adult1 = (Adult)a;
            Adult adult2 = (Adult)b;

            if ((adult1.Phone1 != null || adult1.Phone2 != null) && (adult2.Phone1 != null || adult2.Phone2 != null))
            {
                string a1p1 = (adult1.Phone1 != null)? new string(adult1.Phone1.Where(c => char.IsDigit(c)).ToArray()) : "";
                string a1p2 = (adult1.Phone2 != null)? new string(adult1.Phone2.Where(c => char.IsDigit(c)).ToArray()) : "";
                string a2p1 = (adult2.Phone1 != null)? new string(adult2.Phone1.Where(c => char.IsDigit(c)).ToArray()) : "";
                string a2p2 = (adult2.Phone2 != null)? new string(adult2.Phone2.Where(c => char.IsDigit(c)).ToArray()) : "";

                if ((PartialStringMatch(a1p1, a2p1) || PartialStringMatch(a1p1, a2p2))
                    || (PartialStringMatch(a1p2, a2p1) || PartialStringMatch(a1p2, a2p2)))
                {
                    result = MATCH_RESULT.EQUAL;
                }
                else if ((a1p1.Length > 0 || a1p2.Length > 0) && (a2p1.Length > 0 || a2p2.Length > 0))
                {
                    result = MATCH_RESULT.NOT_EQUAL;
                }
            }

            return result;
        }
    }
}
