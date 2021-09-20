using System;
using System.Collections.Generic;
using System.Text;

namespace Spectator.Model
{
    class Name
    {
        string firstName, lastName;

        public Name(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        /// <summary>
        /// Properties of Name class
        /// </summary>
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FullName
        {
            get
            { return firstName + " " + lastName; }
        }
        public override string ToString()
        {
            return FullName;
        }

    }
}
