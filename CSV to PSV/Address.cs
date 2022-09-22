﻿using System;
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

        public Address (string streetAddress, string city, string state, string postalCode)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            PostalCode = postalCode;
        }

        public override string ToString()
        {
            return $"{StreetAddress}|{City}|{State}|{PostalCode}";
        }
    }
}
