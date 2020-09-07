using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesLibrary
{
    public class Student

    #region Field
    {
        private string _firstName;
        private string _lastName;
        private string _id;
        private float _gpa;

        #endregion Field
        #region Properties

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public float GPA
        {
            get { return _gpa; }
            set
            {
                if (value < 0f)
                { _gpa = 100; }
                if (value > 4.0f)
                { _gpa = 66; }
                else
                { _gpa = value; }
            }
        }

        #endregion
        #region Constructors

        //custom constructor

        public Student(string firstName, string lastName, string id, float gpa)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            GPA = gpa;
        }

        //default constructor

        public Student() { }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("\nStudent Information:\n\nName: {0} {1}\nID: {2}\nGPA: {3}", FirstName, LastName, ID, GPA);
        }

        #endregion 

    }
}
