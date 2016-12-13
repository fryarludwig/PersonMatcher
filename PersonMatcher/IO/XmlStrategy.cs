using System;
using System.Collections.Generic;
using System.Xml.Serialization;

using PersonMatcher.Persons;

namespace PersonMatcher.IO
{
    public class XmlStrategy : FileHandler
    {
        public XmlStrategy() : base("XmlStrategy")
        {
            // Do nothing
        }

        public override List<Person> ParseFile(string filename)
        {
            List<Person> personList = null;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Adult), typeof(Child) });

            if (OpenFile(filename))
            {
                personList = serializer.Deserialize(Reader) as List<Person>;
                Reader.Close();
            }

            return personList;
        }
    }
}