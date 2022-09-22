using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_PSV
{
    internal class Person : IComparable<Person>
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }

        public Address Address { get; init; }

        /// <summary>
        /// A constructor to create a person object and assign all the appropiate properties for it.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="address"></param>
        public Person (string firstName, string lastName, Address address )
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        /// <summary>
        /// A method to override the original to string method to format the string with pipe characters.
        /// </summary>
        /// <returns>A correctly formatted person string, including their address.</returns>
        public override string ToString()
        {
            return $"{FirstName}|{LastName}|{Address}"; 
        }

        /// <summary>
        /// A method to overide ICompares CompareTo method so that we can compare the person objects based on their last names.
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Person? other)
        {
            return String.Compare(this.LastName, other.LastName);
        }
    }
}
