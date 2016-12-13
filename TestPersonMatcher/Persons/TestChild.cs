using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;

namespace TestPersonMatcher.Persons
{
    [TestClass]
    public class TestChild
    {
        [TestMethod]
        public void TestChildConstructor()
        {
            Child person = new Child();
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
            Assert.IsNull(person.NewbornScreeningNumber);
            Assert.IsNull(person.IsPartOfMultipleBirth);
            Assert.IsNull(person.BirthOrder);
            Assert.IsNull(person.BirthCounty);
            Assert.IsNull(person.MotherFirstName);
            Assert.IsNull(person.MotherMiddleName);
            Assert.IsNull(person.MotherLastName);
            Assert.AreEqual(5, person.ToString().Length);
        }
    }
}
