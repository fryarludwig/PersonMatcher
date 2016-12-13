using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;

namespace TestPersonMatcher.Persons
{
    [TestClass]
    public class TestPerson
    {
        [TestMethod]
        public void TestPersonConstructor()
        {
            Person person = new Person();

            Assert.IsNull(person.ObjectId);
            Assert.IsNull(person.StateFileNumber);
            Assert.IsNull(person.SocialSecurityNumber);
            Assert.IsNull(person.FirstName);
            Assert.IsNull(person.MiddleName);
            Assert.IsNull(person.LastName);
            Assert.IsNull(person.BirthYear);
            Assert.IsNull(person.BirthMonth);
            Assert.IsNull(person.BirthDay);
            Assert.IsNull(person.Gender);
            Assert.AreEqual(5, person.ToString().Length);
        }
    }
}
