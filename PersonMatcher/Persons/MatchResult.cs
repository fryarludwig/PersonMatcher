
using System.Runtime.Serialization;
using PersonMatcher.Persons;

namespace PersonMatcher.Persons
{
    [DataContract]
    public class MatchResult
    {
        public MatchResult()
        {
            Person1 = new Person();
            Person2 = new Person();
        }

        public MatchResult(Person a, Person b)
        {
            Person1 = a;
            Person2 = b;
        }

        public override string ToString()
        {
            return $"({Person1.ObjectId?.ToString() ?? "-1"}, {Person2.ObjectId?.ToString() ?? "-1"})";
        }

        [DataMember]
        public Person Person1 { get; set; }
        [DataMember]
        public Person Person2 { get; set; }
    }
}
