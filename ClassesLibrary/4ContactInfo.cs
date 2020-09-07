using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class ContactInfo
    {       
        //fields - implied
        //properties
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        
        //constructors
        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }
        //methods


        public override string ToString()
        {
            return string.Format("\nStreet Address: {0}\nCity: {1}\nState: {2}\nZip: {3}\nPhone: {4}\nEmail: {5}\n", StreetAddress, City, State, Zip, Phone, Email);
        }

        public ContactInfo() { }
    }
}
