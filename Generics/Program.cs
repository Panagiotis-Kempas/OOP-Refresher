using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            CollectionInitializer<int> initializer = new CollectionInitializer<int>(5);
            initializer.AddElementToCollection(5, 8, 12, 74, 13);
            int[] collection = initializer.RetrieveAllElements();
            int number = initializer.RetriveElementOnIndex(3);

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Element on the selected index is {number}");

        }
    }
}
