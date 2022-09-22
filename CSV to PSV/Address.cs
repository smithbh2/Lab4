using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_to_PSV
{
    internal class Address
    {
        public string StreetAddress { get; init; }
        public string City { get; init; }
        public string State { get; init; }
        public string PostalCode { get; init; }

        /// <summary>
        /// A constructor to create an address object and assign all the appropiate properties for it.
        /// </summary>
        /// <param name="streetAddress"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <param name="postalCode"></param>
        public Address (string streetAddress, string city, string state, string postalCode)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
        }
        /// <summary>
        /// A method to override the original to string method to format the string with pipe characters 
        /// </summary>
        /// <returns>A correctly formatted address string.</returns>
        public override string ToString()
        {
            return $"{StreetAddress}|{City}|{State}|{PostalCode}";
        }
    }
}
