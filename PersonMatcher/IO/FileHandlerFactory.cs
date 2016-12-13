namespace PersonMatcher.IO
{
    public static class FileHandlerFactory
    {
        public static FileHandler GetFileHandler(FileHandler.FileType fileType)
        {
            FileHandler newHandler = null;

            switch(fileType)
            {
                case FileHandler.FileType.JSON:
                    {
                        newHandler = new JsonStrategy();
                    }
                    break;

                case FileHandler.FileType.XML:
                    {
                        newHandler = new XmlStrategy();
                    }
                    break;

                default:
                    {
                        newHandler = null;
                        Logger.Error("Unable to determine file parser type");
                    }
                    break;
            }

            return newHandler;
        }

        private static LogUtility Logger = new LogUtility("FileHandlerFactory");
    }
}
