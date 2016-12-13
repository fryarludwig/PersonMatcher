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

        public override List<Person> Load(string filename)
        {
            List<Person> personList = null;
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>), new Type[] { typeof(Person), typeof(Adult), typeof(Child) });

            if (OpenReader(filename))
            {
                personList = serializer.Deserialize(Reader) as List<Person>;
                Reader.Close();
            }

            return personList;
        }

        public override bool Save(string filename, List<MatchResult> matches)
        {
            bool success = false;
            XmlSerializer serializer = new XmlSerializer(typeof(List<MatchResult>), new Type[] { typeof(MatchResult), typeof(Person), typeof(Adult), typeof(Child) });

            if (OpenWriter(filename))
            {
                serializer.Serialize(Writer.BaseStream, matches);
                Writer.Close();
                success = true;
            }

            return success;
        }
    }
}