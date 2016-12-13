using System;
using System.Collections.Generic;
using System.IO;

using PersonMatcher.Persons;
using PersonMatcher.Patterns;

namespace PersonMatcher.IO
{
    public abstract class FileHandler
    {
        public FileHandler(String handlerName)
        {
            Logger = new LogUtility(handlerName);
        }

        protected StreamReader Reader { get; set; }
        protected StreamWriter Writer { get; set; }
        public abstract List<Person> Load(string filename);
        public abstract bool Save(string filename, List<MatchResult> persons);

        protected virtual bool OpenReader(string filename)
        {
            bool result = false;
            try
            {
                Reader = new StreamReader(filename);
                result = true;
            }
            catch (Exception err)
            {
                Console.WriteLine($"Cannot open input file {filename}, error={err}");
            }

            return result;
        }


        protected virtual bool OpenWriter(string filename)
        {
            bool result = false;
            try
            {
                if (Directory.Exists(Path.GetDirectoryName(filename)))
                {
                    Writer = new StreamWriter(filename);
                    result = true;
                }
            }
            catch (Exception err)
            {
                Console.WriteLine($"Cannot open output file {filename}, error={err}");
            }

            return result;
        }
        
        public enum FileType
        {
            JSON,
            XML
        }

        protected LogUtility Logger;
    }
}
