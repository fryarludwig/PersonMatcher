
using PersonMatcher.Persons;

namespace PersonMatcher.Patterns
{
    public class MatchResult
    {
        public MatchResult(Person a, Person b)
        {
            if (a.GetType().Equals(b.GetType()))
            {
                if (a.GetType().Equals(typeof(Adult)))
                {
                    Person1 = a;
                    Person2 = b;
                }
                else
                {
                    Person1 = a;
                    Person2 = b;
                }
            }
        }

        public override string ToString()
        {
            return $"({Person1.ObjectId}, {Person2.ObjectId})";
        }

        public Person Person1 { get; set; }
        public Person Person2 { get; set; }
    }
}
