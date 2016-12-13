using System;
using System.Runtime.Serialization;

namespace PersonMatcher.Persons
{
    [DataContract]
    public class Adult : Person
    {
        [DataMember]
        public String Phone1 { get; set; }

        [DataMember]
        public String Phone2 { get; set; }
    }
}
