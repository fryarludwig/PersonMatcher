using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

using PersonMatcher.Persons;

namespace PersonMatcher.Patterns
{
    public class GroupingPattern : BasePattern
    {
        public GroupingPattern() : base("ScoringPattern", 8)
        {
            NameFieldNames = new List<string>() { "FirstName", "MiddleName", "LastName" };
            BirthdayFieldNames = new List<string>() { "BirthYear", "BirthMonth", "BirthDay" };
            ChildFieldNames = new List<string>() { "MotherFirstName", "MotherMiddleName", "MotherLastName" };
        }

        protected override MATCH_RESULT InternalCompare(Person a, Person b)
        {
            int score = 0;
            score += ScoreStringFields(a, b, NameFieldNames);
            score += ScoreNumericFields(a, b, BirthdayFieldNames);

            if (a.GetType() == b.GetType() && a.GetType() == typeof(Child))
            {
                score += EvaluateChildFields((Child)a, (Child)b, ChildFieldNames);
            }

            if (score != 0)
            {
                return (score > 0) ? MATCH_RESULT.EQUAL : MATCH_RESULT.NOT_EQUAL;
            }

            return MATCH_RESULT.INCONCLUSIVE;
        }

        protected int ScoreStringFields(Person a, Person b, List<string> fields)
        {
            int groupScore = 0;
            int score = 0;
            IList<PropertyInfo> personProperties = new List<PropertyInfo>(typeof(Person).GetProperties());

            foreach (string fieldName in fields)
            {
                PropertyInfo prop = typeof(Person).GetProperty(fieldName);
                if (prop == null) { continue; }
                String valueA = (String)prop.GetValue(a);
                String valueB = (String)prop.GetValue(b);

                if (valueA != null && valueB != null && (valueA.Length > 0 && valueB.Length > 0)
                    && (valueA.GetType() == typeof(String)))
                {
                    groupScore++;
                    score += (PartialStringMatch(valueA, valueB)) ? WeightMap[fieldName] * groupScore : WeightMap[fieldName] * groupScore * -1;
                }
            }

            return score;
        }

        protected int ScoreNumericFields(Person a, Person b, List<string> fields)
        {
            int groupScore = 0;
            int score = 0;
            IList<PropertyInfo> personProperties = new List<PropertyInfo>(typeof(Person).GetProperties());

            foreach (string fieldName in fields)
            {
                PropertyInfo prop = typeof(Person).GetProperty(fieldName);
                if (prop == null) { continue; }
                int? valueA = (int?)prop.GetValue(a);
                int? valueB = (int?)prop.GetValue(b);

                if ((valueA != null && valueB != null) && (valueA.GetType() == typeof(int)))
                {
                    groupScore++;
                    score += (Math.Abs((int)valueA - (int)valueB) < NUMERIC_THRESHOLD) ? WeightMap[fieldName] * groupScore : WeightMap[fieldName] * groupScore * -1;
                }
            }

            return score;
        }

        protected int EvaluateChildFields(Child a, Child b, List<string> fields)
        {
            int groupScore = 0;
            int score = 0;

            foreach (string fieldName in fields)
            {
                PropertyInfo prop = typeof(Person).GetProperty(fieldName);
                if (prop == null) { continue; }
                String valueA = (String)prop.GetValue(a);
                String valueB = (String)prop.GetValue(b);

                if (valueA != null && valueB != null && (valueA.Length > 0 && valueB.Length > 0)
                    && (valueA.GetType() == typeof(String)))
                {
                    groupScore++;
                    score += (PartialStringMatch(valueA, valueB)) ? WeightMap[fieldName] * groupScore : WeightMap[fieldName] * groupScore * -1;
                }
            }

            return score;
        }

        protected List<String> NameFieldNames { get; set; }
        protected List<String> BirthdayFieldNames { get; set; }
        protected List<String> ChildFieldNames { get; set; }
        protected const int NUMERIC_THRESHOLD = 2;
    }
}