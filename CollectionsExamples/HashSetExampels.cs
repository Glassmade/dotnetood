using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    public static class HashSetExampels
    {

        static HashSet<string> myHashSet = new HashSet<string>();

        public static void populateHashSetByOne(string inputElement)
        {
            myHashSet.Add(inputElement);
        }

        public static void printAllElementsOfTheHashSet()
        {
            foreach (string printedString in myHashSet)
            {
                Console.WriteLine(printedString);
            }
        }

        public static void countAllelementsOfTheHashSet()
        {
            Console.WriteLine("The total number of elements in this hashSet is: " + myHashSet.Count);
        }


    }
}
