using System;
using System.Runtime.Serialization;

namespace PersonMatcher.Persons
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int? ObjectId { get; set; }

        [DataMember]
        public String StateFileNumber { get; set; }

        [DataMember]
        public String SocialSecurityNumber { get; set; }

        [DataMember]
        public String FirstName { get; set; }

        [DataMember]
        public String MiddleName { get; set; }

        [DataMember]
        public String LastName { get; set; }

        [DataMember]
        public int? BirthYear { get; set; }

        [DataMember]
        public int? BirthMonth { get; set; }

        [DataMember]
        public int? BirthDay { get; set; }

        [DataMember]
        public String Gender { get; set; }

        public override string ToString()
        {
            return $"{ObjectId.ToString().PadRight(2)}: {FirstName} {LastName}";
        }
    }
}
