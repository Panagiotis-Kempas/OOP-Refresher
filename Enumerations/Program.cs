using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int day = random.Next(1, 7);
            DaysInWeek weekDay;

            //Console.WriteLine(day);
            //Console.WriteLine((int)day);

            switch (day)
            {
                case 1: Console.WriteLine(DaysInWeek.Monday);  break;
                case 2:  Console.WriteLine(DaysInWeek.Tuesday); break;
                case 3: Console.WriteLine(DaysInWeek.Wednesday); break;
                case 4: Console.WriteLine(DaysInWeek.Thursday); break;
                case 5: Console.WriteLine(DaysInWeek.Friday); break;
                case 6: Console.WriteLine(DaysInWeek.Saturday); break;
                case 7: Console.WriteLine(DaysInWeek.Sunday); break;
            }
        }
    }
}
