using System;
using System.Collections.Generic;


namespace CollectionsExamples
{
    public static class DictionaryExample
    {

        static Dictionary<int, string> myDictionary = new Dictionary<int, string>();


        public static void populateDictionaryByOne(int inputedInteger, string inputString)
        {
            myDictionary.Add(inputedInteger, inputString);
        }

        public static void countDictionaryEntries()
        {
            Console.WriteLine("The total number of entries in this dictionare is/are:" + myDictionary.Count);
        }

        public static void removeElementFromDictionaryByKey(int inputedInteger)
        {
            Console.WriteLine("We're about to remove the " + myDictionary[inputedInteger]);
            myDictionary.Remove(inputedInteger);
        }

        public static void printDictionary()
        {
            foreach (KeyValuePair<int,string> kvp in myDictionary)
            {
                Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value);
            }
        }

        public static void printSpecificEntryOfDictionary(int inputedInteger)
        {
            foreach (KeyValuePair<int, string> kvp in myDictionary)
            {
                if (kvp.Key == inputedInteger) { 
                    Console.WriteLine("Specific card requested -=-=-");
                    Console.WriteLine("Key: " + kvp.Key + " Value: " + kvp.Value);
                    Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-");
                }
            }

        }


    }
}
