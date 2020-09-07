using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Customer
    {

       // private ContactInfo _contactinformation;

        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }
            
        

        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation) 
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }


        public override string ToString()
        {
            return string.Format("Customer ID: {0}\nCustomer Name: {1} {2}\n{3}\n",
                CustomerID,
                FirstName,
                LastName,
                ContactInformation);
        }

        public Customer() { }

 
        
    }
}
