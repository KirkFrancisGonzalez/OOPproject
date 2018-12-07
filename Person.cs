using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace OOP_Project
{
    public class Person
    {
        

        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public string Birthdate;
        public string Address;

        public Person(string firstName, string middleInitial, string lastName)
        {
            
            FirstName = firstName;
            MiddleInitial = middleInitial;
            LastName = lastName;

        }

        public string GetFullName()
        {
            LastName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(LastName);

            return string.Format(FirstName.First().ToString().ToUpper() + FirstName.Substring(1).ToLower() + " " + MiddleInitial.ToString().ToUpper()
               + "." + " " + LastName.First().ToString().ToUpper()) + LastName.Substring(1).ToLower();
        }

        internal object GetFullName(object firstName, object middleInitial, object lastName)
        {
            throw new NotImplementedException();
        }
    }
}
