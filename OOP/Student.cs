using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Student
    {
        private string _name;
        private string _lastname;

        public Student()
        {
            _name = string.Empty;
            _lastname = string.Empty;
        }


        public Student(string name,string lastname)
        {
            _name=name;
            _lastname=lastname;
        }
        public string GetFullName()
        {
            return _name + " " + _lastname;
        }

    }
}
