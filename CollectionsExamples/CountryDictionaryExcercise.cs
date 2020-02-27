using System;
using System.Collections.Generic;

namespace CollectionsExamples
{
    public class CountryDictionaryExcercise : ICustomDictionary<String, String>
    {
   
        private Dictionary<string, string> _countryDictionary; 
  
        public CountryDictionaryExcercise()
        {
            _countryDictionary = null;
            _countryDictionary = new Dictionary<string, string>();
            _countryDictionary.Add("UK", "United Kingdom");
            _countryDictionary.Add("US", "United States of America");
            _countryDictionary.Add("FR", "France");
            _countryDictionary.Add("GE", "Germany");
            _countryDictionary.Add("IT", "Italy");

        }

        public void countTheCollection()
        {
            if (_countryDictionary.Count == 1 )
                Console.WriteLine("The is only " + _countryDictionary.Count + "entry");
            else
                Console.WriteLine("The total entries are: " + _countryDictionary.Count);
        }

        public void populateTheCollectionByOne(string inutedAbbreviation, string inputedFullName)
        {
            _countryDictionary.Add(inutedAbbreviation.ToUpper(), inputedFullName);
        }

        public void printTheCollection()
        {
            foreach (KeyValuePair<string, string> kvp in _countryDictionary)
                Console.WriteLine("The abbreviated is: [" + kvp.Key + "] The full name is: " + kvp.Value);
        }

        public void removeFromCollectionByOne(string inputedAbbreviation)
        {
            _countryDictionary.Remove(inputedAbbreviation.ToUpper());
        }

        public void updateTheCollectionByOne(string inputedAbbreviation, string inputedFullName)
        {
            _countryDictionary[inputedAbbreviation.ToUpper()] = inputedFullName;
        }

        public void printTheCollectionByOne(string inputedAbbreviation)
        {
            if (_countryDictionary[inputedAbbreviation] != null)
                Console.WriteLine("The full name of the abbreviation [" + inputedAbbreviation.ToUpper() + "] is " + _countryDictionary[inputedAbbreviation].ToString());
            else
                Console.WriteLine("Not present");
        }

        public Dictionary<string, string> countryDictionary
        {
            get
            {
                return _countryDictionary;
            }
            set
            {
                countryDictionary = _countryDictionary;
            }
        }

       
    }
}
