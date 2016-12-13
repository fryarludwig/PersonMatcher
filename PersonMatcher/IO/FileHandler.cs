using System;
using System.Collections.Generic;
using System.IO;

using PersonMatcher.Persons;

namespace PersonMatcher.IO
{
    public abstract class FileHandler
    {
        public FileHandler(String handlerName)
        {
            Logger = new LogUtility(handlerName);
        }

        protected StreamReader Reader { get; set; }
        protected bool OpenFile(String filename)
        {
            bool result = false;
            try
            {
                Reader = new StreamReader(filename);
                result = true;
                Logger.Info($"Successfully opened input file {filename}");
            }
            catch (Exception err)
            {
                Logger.Info($"unable to open input file {filename}, error={err}");
            }

            return result;
        }

        public abstract List<Person> ParseFile(String filename);

        public enum FileType
        {
            JSON,
            XML
        }

        protected LogUtility Logger;
    }
}
