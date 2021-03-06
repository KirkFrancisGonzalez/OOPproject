﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT_tinood_
{
    class PersonClass
    {
        public string FirstName;
        public string MiddleInitial;
        public string LastName;
        public string Birthdate;
        public string Address;

        public PersonClass(string firstName, string middleInitial, string lastName)
        {
            FirstName = firstName;
            MiddleInitial = middleInitial;
            LastName = lastName;
        }

        public static string GetTitleCase(string fullName)
        {
            string[] names = fullName.Split(' ');
            List<string> currentNameList = new List<string>();
            foreach (var name in names)
            {
                if(Char.IsUpper(name[0]))
                {
                    currentNameList.Add(name);
                }
                else
                {
                    currentNameList.Add(Char.ToUpper(name[0]) + name.Remove(0, 1));
                }
            }
            return string.Join(" ", currentNameList.ToArray()).Trim();
        }
        public string GetFullName()
        {
            LastName = GetTitleCase(LastName);

            return string.Format("{0} {1}. {2}", FirstName.First().ToString().ToUpper() + FirstName.Substring(1).ToLower(),
                MiddleInitial.ToString().ToUpper(), LastName);
        }
    }

}
