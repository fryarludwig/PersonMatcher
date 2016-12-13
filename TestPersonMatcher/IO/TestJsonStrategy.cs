using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;
using System.Collections.Generic;

namespace TestPersonMatcher.IO
{
    [TestClass]
    public class TestJsonStrategy
    {
        [TestMethod]
        public void ReadJsonFile()
        {
            FileHandler handler = FileHandlerFactory.GetFileHandler(FileHandler.FileType.JSON);
            Assert.IsNotNull(handler);
            Assert.AreEqual(handler.GetType(), typeof(JsonStrategy));
            List<Person> personList = handler.Load("../../../TestData/PersonTestSet_01.json");
            Assert.IsNotNull(personList);
            Assert.AreEqual(personList.Count, 6);
        }
    }
}
