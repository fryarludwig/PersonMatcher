using System;
using System.Runtime.Serialization;

namespace PersonMatcher.Persons
{
    [DataContract]
    public class Child : Person
    {
        [DataMember]
        public String NewbornScreeningNumber { get; set; }

        [DataMember]
        public String IsPartOfMultipleBirth { get; set; }

        [DataMember]
        public int? BirthOrder { get; set; }

        [DataMember]
        public String BirthCounty { get; set; }

        [DataMember]
        public String MotherFirstName { get; set; }

        [DataMember]
        public String MotherMiddleName { get; set; }

        [DataMember]
        public String MotherLastName { get; set; }
    }
}
