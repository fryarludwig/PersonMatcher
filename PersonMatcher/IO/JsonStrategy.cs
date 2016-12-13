using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Json;

using PersonMatcher.Persons;

namespace PersonMatcher.IO
{
    public class JsonStrategy : FileHandler
    {
        public JsonStrategy() : base("JsonStrategy")
        {
            // Do nothing
        }

        public override List<Person> Load(string filename)
        {
            List<Person> personList = null;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Adult), typeof(Child) });

            if (OpenReader(filename))
            {
                personList = serializer.ReadObject(Reader.BaseStream) as List<Person>;
                Reader.Close();
            }

            return personList;
        }

        public override bool Save(string filename, List<MatchResult> matches)
        {
            bool success = false;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<MatchResult>), new Type[] { typeof(MatchResult), typeof(Person), typeof(Adult), typeof(Child) });

            if (OpenWriter(filename))
            {
                serializer.WriteObject(Writer.BaseStream, matches);
                Writer.Close();
                success = true;
            }

            return success;
        }
    }
}
