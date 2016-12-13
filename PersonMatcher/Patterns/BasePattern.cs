using System;

using PersonMatcher.Persons;
using PersonMatcher.IO;
using System.Collections.Generic;

namespace PersonMatcher.Patterns
{
    public abstract class BasePattern
    {
        public BasePattern(String handlerName, int weight, Type required = null)
        {
            Logger = new LogUtility(handlerName);
            WeightMap = new Dictionary<string, int>();
            AllowAdult = (required == null || required == typeof(Adult));
            AllowChild = (required == null || required == typeof(Child));
            PopulateFieldWeights();
            Weight = (weight > 10)? 0 : weight;
        }

        protected void PopulateFieldWeights()
        {
            WeightMap["ObjectId"] = 0;
            WeightMap["StateFileNumber"] = 9;
            WeightMap["SocialSecurityNumber"] = 10;
            WeightMap["FirstName"] = 5;
            WeightMap["MiddleName"] = 4;
            WeightMap["LastName"] = 6;
            WeightMap["BirthYear"] = 4;
            WeightMap["BirthMonth"] = 4;
            WeightMap["BirthDay"] = 4;
            WeightMap["Gender"] = 6;

            if (AllowAdult)
            {
                WeightMap["Phone1"] = 3;
                WeightMap["Phone2"] = 3;
            }

            if (AllowChild)
            {
                WeightMap["NewbornScreeningNumber"] = 10;
                WeightMap["IsPartOfMultipleBirth"] = 4;
                WeightMap["BirthOrder"] = 2;
                WeightMap["BirthCounty"] = 4;
                WeightMap["MotherFirstName"] = 6;
                WeightMap["MotherMiddleName"] = 5;
                WeightMap["MotherLastName"] = 4;
            }
        }

        public bool CanHandleType(Type type)
        {
            return ((type == null || (AllowAdult && AllowChild))
                || (type == typeof(Adult) && AllowAdult) 
                || (type == typeof(Child) && AllowChild));
        }

        public MATCH_RESULT Compare(Person a, Person b)
        {
            if (a != null && b != null
                && (CanHandleType(a.GetType()) && CanHandleType(b.GetType())))
            {
                return InternalCompare(a, b);
            }

            return MATCH_RESULT.INCONCLUSIVE;
        }

        protected abstract MATCH_RESULT InternalCompare(Person a, Person b);

        public enum MATCH_RESULT
        {
            NOT_EQUAL = -1,
            INCONCLUSIVE = 0,
            EQUAL = 1
        }

        public static bool PartialStringMatch(String s1, String s2)
        {
            if ((s1.Length > 0 && s2.Length > 0)
                && (s1 == s2 || (s2.Contains(s1) || s1.Contains(s2))))
            {
                return true;
            }

            return false;
        }

        protected LogUtility Logger;
        public int Weight { get; set; }
        public bool AllowChild { get; set; }
        public bool AllowAdult { get; set; }
        public Dictionary<string, int> WeightMap { get; set; }
    }
}
