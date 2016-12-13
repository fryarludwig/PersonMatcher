using System;
using System.Collections.Generic;

namespace PersonMatcher.IO
{
    public static class FileHandlerFactory
    {
        static FileHandlerFactory()
        {
            RegisteredHandlers = new Dictionary<FileHandler.FileType, Type>();
            RegisterFileHandler(FileHandler.FileType.JSON, typeof(JsonStrategy));
            RegisterFileHandler(FileHandler.FileType.XML, typeof(XmlStrategy));
        }

        public static void RegisterFileHandler(FileHandler.FileType fileTypeDef, Type matcherType)
        {
            RegisteredHandlers[fileTypeDef] = matcherType;
        }

        public static FileHandler GetFileHandler(FileHandler.FileType fileType)
        {
            FileHandler newHandler = null;

            if (RegisteredHandlers.ContainsKey(fileType))
            {
                newHandler = Activator.CreateInstance(RegisteredHandlers[fileType]) as FileHandler;
            }
            else
            {
                Logger.Error("Unable to determine file parser type");
            }

            return newHandler;
        }

        private static Dictionary<FileHandler.FileType, Type> RegisteredHandlers { get; set; }
        private static LogUtility Logger = new LogUtility("FileHandlerFactory");
    }
}
