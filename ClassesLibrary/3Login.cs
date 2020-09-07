using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Login
    {
        //fields

        //properties
        public string UserName { get; set; }
        public string Password { get; set; }

        //constructors
        public Login(string username, string password)
        {
            UserName = username;
            Password = password;
        }

        public Login() { }

        public override string ToString()
        {
            return string.Format("\nUsername: {0}\nPassword:{1}\n", UserName, Password);
        }
        //methods
    }
}
