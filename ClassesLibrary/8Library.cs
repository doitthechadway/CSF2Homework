using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Library
    {
        //fields
        
        //properties

        public List<Book> Books { get; set; }
        public string LibraryName { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }

        //constructors

        public Library(List<Book> books, string libraryName, string streetAddress, string city, string state, string zip)
        {
            Books = books;
            LibraryName = libraryName;
            StreetAddress = streetAddress;
            City = city;
        }

        //methods
        public override string ToString()
        {

            string books = "";

            foreach (Book book in Books)
            {
                books += book + "\n";
            }

            return string.Format("Booklist: {5}\nLibrary: {0}\nStreet Address: {1}\nCity: {2}\nState: {3}\nZip: {4}\n",
                LibraryName,
                StreetAddress,
                City,
                State,
                Zip,
                books);
        }
    }
}
