using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.CSharpTricks
{
    public class Person
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public DateTime BirthDate { set; get; }

        public void Deconstruct(out string firstName,out string lastName)
        {
            firstName = FirstName;
            lastName = LastName;
        }
    }
}
