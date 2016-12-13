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
    public class TestFileHandlerFactory
    {
        [TestMethod]
        public void TestFileHandlerFactoryJson()
        {
            FileHandler handler = FileHandlerFactory.GetFileHandler(FileHandler.FileType.JSON);
            Assert.IsNotNull(handler);
            Assert.AreEqual(handler.GetType(), typeof(JsonStrategy));
            List<Person> personList = handler.Load("../../../TestData/PersonTestSet_01.json");
            Assert.IsNotNull(personList);
            Assert.AreEqual(personList.Count, 6);
        }

        [TestMethod]
        public void TestFileHandlerFactoryXml()
        {
            FileHandler handler = FileHandlerFactory.GetFileHandler(FileHandler.FileType.XML);
            Assert.IsNotNull(handler);
            Assert.AreEqual(handler.GetType(), typeof(XmlStrategy));
            List<Person> personList = handler.Load("../../../TestData/PersonTestSet_11.xml");
            Assert.IsNotNull(personList);
            Assert.AreEqual(personList.Count, 9);
        }
    }
}
