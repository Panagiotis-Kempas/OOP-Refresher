using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Student
    {
        private string _name;
        private string _lastname;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public Student(string name,string lastName)
        {
            _name = name;
            _lastname = lastName;
        }

        public string GetFullName()
        {
            return _name + " " + _lastname;
        }
    }
}
