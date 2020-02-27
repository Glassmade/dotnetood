using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    public static class ArrayListExamples
    {
        static ArrayList stringArrayList = new ArrayList();


        public static void populateTheArrayListByOne(String inputElement)
        {
            stringArrayList.Add(inputElement);
            Console.WriteLine("We inputed an string of " + stringArrayList[stringArrayList.Count - 1]);
        }

        public static void countElementsOfTheArrayList()
        {
            Console.WriteLine("We have a total of " + stringArrayList.Count + " elements on the list");
        }

        public static void printAllelementsOfTheArrayList()
        {
            foreach (string printedElement in stringArrayList)
            {
                Console.WriteLine(stringArrayList.IndexOf(printedElement) + " " + printedElement);
            }
        }

        public static IEnumerable<string> getAllElementsOfTheArrayListWithAnIterator()
        {
            foreach (string element in stringArrayList)
                yield return element;
        }

        public static void printAllElementsOfTheArrayListWithAnIterator()
        {
            foreach (string printedElement in getAllElementsOfTheArrayListWithAnIterator())
            {
                Console.WriteLine(printedElement);
            }
        }


    }
}
