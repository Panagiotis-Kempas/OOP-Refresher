using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class CollectionInitializer<T>
    {
        private T[] collection;

        public CollectionInitializer(int collectionLength)
        {
            collection = new T[collectionLength];
        }

        public void AddElementToCollection(params T[] elements)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                collection[i] = elements[i];
            }
        }

        public T[] RetrieveAllElements()
        {
            return collection;
        }

        public T RetriveElementOnIndex(int index)
        {
            return collection.ElementAt(index);
        }
    }
}
