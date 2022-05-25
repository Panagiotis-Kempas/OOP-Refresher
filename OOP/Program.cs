using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine(student.GetFullName()); //default constructor

            Student student1 = new Student("Panagiotis","Kempas");
            Console.WriteLine(student1.GetFullName());


        }
    }
}
