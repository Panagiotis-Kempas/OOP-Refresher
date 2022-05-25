using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("panagiotis", "kempas");
            string name = student.Name;
            string lastName = student.Lastname;

            student.Name = "Vaggelis";
            student.Lastname = "Alexopoulos";
        }
    }
}
