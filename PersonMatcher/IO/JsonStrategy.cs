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

        public override List<Person> ParseFile(string filename)
        {
            List<Person> personList = null;
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Adult), typeof(Child) });

            if (OpenFile(filename))
            {
                personList = serializer.ReadObject(Reader.BaseStream) as List<Person>;
                Reader.Close();
            }

            return personList;
        }
    }
}
