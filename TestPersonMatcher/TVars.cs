using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using PersonMatcher;
using PersonMatcher.IO;
using PersonMatcher.Patterns;
using PersonMatcher.Persons;

namespace TestPersonMatcher
{
    public static class TVars
    {
        static TVars()
        {
            Slim1 = new Adult();
            Slim1.FirstName = "Marshall";
            Slim1.MiddleName = "C";
            Slim1.LastName = "Mathers";
            Slim1.Gender = "Male";
            ((Adult)Slim1).Phone1 = "8675309";

            Slim2 = new Adult();
            Slim2.FirstName = "Marshall";
            Slim2.MiddleName = "Charlie";
            Slim2.LastName = "Mathers";
            Slim2.Gender = "M";
            ((Adult)Slim2).Phone2 = "8675309";
            ((Adult)Slim2).Phone1 = "(800) 867-5309";

            NotSlim = new Adult();
            NotSlim.FirstName = "Marsha";
            NotSlim.LastName = "Matthews";
            NotSlim.Gender = "F";
            ((Adult)NotSlim).Phone2 = "8675308";

            Tim1 = new Adult();
            Tim1.SocialSecurityNumber = "123 456 789";
            Tim1.StateFileNumber = "bad_value1";

            TimsFakeId = new Adult();
            TimsFakeId.SocialSecurityNumber = "12 456 789";
            TimsFakeId.StateFileNumber = "gnarly";

            Tim2 = new Child();
            Tim2.SocialSecurityNumber = "123 456 789";
            Tim1.StateFileNumber = "65432111";

            Child a1 = new Child();
            a1.FirstName = "Abram";
            a1.MiddleName = "Ceasar";
            a1.LastName = "Kendall";
            a1.Gender = "Male";
            a1.MotherFirstName = "Mom";
            a1.MotherMiddleName = "Mommy";
            a1.MotherLastName = "Momma";
            Abram1 = a1;

            Child a2 = new Child();
            a2.FirstName = "Abram";
            a2.MiddleName = "Ceasar";
            a2.LastName = "Kendall";
            a2.Gender = "Male";
            a2.MotherFirstName = "Mom";
            a2.MotherMiddleName = "Mommy";
            a2.MotherLastName = "Momma";
            Abram2 = a2;

            Adult a3 = new Adult();
            a3.FirstName = "Abram";
            a3.MiddleName = "C";
            a3.LastName = "Kendall";
            a3.Gender = "Male";
            a3.Phone1 = "801 3672";
            Abram3 = a3;
        }

        public static Person Slim1 { get; set; }
        public static Person Slim2 { get; set; }
        public static Person NotSlim { get; set; }
        public static Person Tim1 { get; set; }
        public static Person Tim2 { get; set; }
        public static Person TimsFakeId { get; set; }
        public static Person Abram1 { get; set; }
        public static Person Abram2 { get; set; }
        public static Person Abram3 { get; set; }
    }
}
