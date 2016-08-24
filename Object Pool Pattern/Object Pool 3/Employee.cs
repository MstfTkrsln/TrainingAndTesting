using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Object_Pool_2
{
    public class Employee
    {

        public static int _intCounter = 0;

        public Employee()
        {
            _intCounter = _intCounter + 1;
            _FirstName = "FirstName" + _intCounter.ToString();
            _LastName = "LastName" + _intCounter.ToString();
        }

        private string _FirstName;

        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }
        private string _LastName;

        public string LastName
        {
            get { return _LastName; }
            set { _LastName = value; }
        }
    }
}

