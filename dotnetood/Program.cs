using System;
using Bank;
using Bank.Model;
using Bank.Model.AccountBundle;
using BetterBank.Model;
using BetterBank;
using PassingArguments;
using EnumExample;
using FizzBuzz;
using CollectionsExamples;
using FizzBuzz.Tests;
using System.Collections;
using ExceptionHandling;
using Newtonsoft.Json;

namespace dotnetood
{

    class Program
    {

        private static readonly log4net.ILog logger = log4net.LogManager.GetLogger("Program.cs");

        static void Main(string[] args)
        {
            //OOD_Week_ONE();

            //OOD_Week2_Day1();
            //OOD_Week2_Day2();
            //OOD_Week2_Day3();
            OOD_Week_Day4();

            Console.ReadLine();
        }

        private static void OOD_Week_Day4()
        {
            Console.WriteLine("OOD Week 2 - Day 4");
            ExceptionCompilation exceptionsExamples = new ExceptionCompilation();

            //exceptionsExamples.fileOpenExample("c:/windows/yoyoyo.txt"); // Not existing document
            //exceptionsExamples.divideWithZeroExample(5, 0);
            //exceptionsExamples.onlyPositiveIntegersPlease(-5);


            //string filename = @"C:\Users\Dimitrios.Koulialis\source\repos\dotnetood\dotnetood\jsonTarget.js";
            //FileManager.deleteContentOfFile(filename);
            //MyGenericSerialization myBetterSerialization = new MyGenericSerialization();
            //Address carolineAddress = new Address("16", "Hope St.", "Glasgow", "GL2 PP12");
            //Person jim = new Person(77, "Dimitrios", "Koulialis");
            //FileManager.writeMessageToFile(filename, myBetterSerialization.serializeMyObject(carolineAddress));
            //FileManager.writeMessageToFile(filename, myBetterSerialization.serializeMyObject(jim));
            //FileManager.readMessageFromFile(filename);


            string newFilename = @"C:\Users\Dimitrios.Koulialis\source\repos\dotnetood\dotnetood\jsonDraw.js";
            JsonSerializerSettings test = new JsonSerializerSettings(); 
            Person sunny = JsonConvert.DeserializeObject<Person>(FileManager.stringMessageFromFile(newFilename));
            Console.WriteLine(sunny.newToString());

        }

        private static void OOD_Week2_Day3()
        {
            //Console.WriteLine("OOD Week 2 - Day 3");
            //Person jim = new Person(12, "Jim", "Kewl");
            //Person sunny = new Person(7, "Sunny", "Kudu");
            //Person Caroline = new Person(1, "Caroline", "Douglas");
            //Person Carolinee = new Person(1, "Caroline", "Bouglas");

            //ArrayList people = new ArrayList();
            //people.Add(jim);
            //people.Add(sunny);
            //people.Add(Caroline);
            //people.Add(Carolinee);



            //arrayListPrinter(people);

            //people.Sort(Person.PersonComparerByKey());

            //Console.WriteLine("\n-=-=- After sorting -=-=-=-=-");

            //arrayListPrinter(people);

            tryToDivideWithZero();

        }

        private static void tryToDivideWithZero()
        {
            try
            {
                int ten = 10;
                int zero = 0;
                int division = ten / zero;
            }
            catch (DivideByZeroException exception)
            {
                logger.Error(exception.Message);
                Console.WriteLine("You cannot divide with zero");
            }

            logger.Info("Application still running");
        }

        private static void OOD_Week2_Day2()
        {
            Console.WriteLine("OOD Week 2 - Day 2\nJust More Tets");
            Person jim = new Person(12, "Jim", "Kewl");
            Person sunny = new Person(7, "Sunny", "Kudu");
            Person Caroline = new Person(1, "Caroline", "Douglas");

            ArrayList people = new ArrayList();
            people.Add(jim);
            people.Add(sunny);
            people.Add(Caroline);

            arrayListPrinter(people);

            people.Sort();

            Console.WriteLine("\n-=-=- After sorting -=-=-=-=-");

            arrayListPrinter(people);


        }

        private static void arrayListPrinter(ArrayList people)
        {
            foreach (Person printPerson in people)
                Console.WriteLine(printPerson.newToString());
        }

        private static void OOD_Week2_Day1()
        {
            Console.WriteLine("OOD Week 2 - Day 1");
            Address bankAdress = new Address("32", "Hope St.", "Glasgow", "GL1 ABC", "Lanarkshire");
            NewBank myBank = new NewBank("ThaBank", bankAdress);
            Address jimsAddress = new Address("26", "Gilmour St.", "Paisley", "PA1 GG5", "Renfrewshire");
            DateTime jimsBirthday = new DateTime(1984, 10, 12);
            Person jim = new Person(7, "Dimitrios", "Koulialis", jimsAddress, jimsBirthday);
            Int32 jimsKey = jim.key;
            BetterBank.Model.AccountBundle.CurrentsAccount jimsAccount = new BetterBank.Model.AccountBundle.ConcreteCurrentAccount(jimsKey,500m,jim,250m);

            myBank.accounts.Add(jimsAccount.bindKey, jimsAccount);
            myBank.printAllAccounts();

            jimsAccount.setNewOverdraft(500m);
            myBank.printAllAccounts();
            Console.WriteLine("\n\n-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine("\nIntroduction to TDD, we tested Bank and FizzBuzz classes and their methods! \n Check *.Tests.cs projects and their classes\n");
            Console.WriteLine("-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-");

            
        }


        #region FIRST WEEK OF OOD 
        private static void OOD_Week_ONE()
        {
            //OOD_Week1_Day1();
            //OOD_Week1_Day2();
            //OOD_Week1_Day3();
            //OOD_Week1_Day4();
            //OOD_Week1_Day5();
        }

        private static void OOD_Week1_Day5()
        {
            Console.WriteLine("OOD Week 1 - Day 5");
            Console.Write("--Chaged and refractored the examples of: ");
            OOD_Week1_Day3();

        }

        private static void OOD_Week1_Day4()
        {
            Console.WriteLine("OOD Week 1 - Day 4");

            //FizzBuzzy myFizzzBuzz = new FizzBuzzy();
            //myFizzzBuzz.numberRangeToTestFizzOrBuzzStartingZero(50);

            //ArrayListExamples.populateTheArrayListByOne("Hello");
            //ArrayListExamples.populateTheArrayListByOne("World");
            //ArrayListExamples.populateTheArrayListByOne(null); // Null allowed
            //ArrayListExamples.populateTheArrayListByOne("Hello"); // Duplicates allowed
            //ArrayListExamples.countElementsOfTheArrayList();
            //ArrayListExamples.printAllelementsOfTheArrayList();
            //ArrayListExamples.printAllElementsOfTheArrayListWithAnIterator();

            //HashSetExampels.populateHashSetByOne("Hello");
            //HashSetExampels.populateHashSetByOne("World");
            //HashSetExampels.populateHashSetByOne(null);
            //// The next two entries will not be allowed because they are duplicates.
            //HashSetExampels.populateHashSetByOne("World");
            //HashSetExampels.populateHashSetByOne(null); // Did not accept second null, Does not allows duplicates
            //HashSetExampels.printAllElementsOfTheHashSet();
            //HashSetExampels.countAllelementsOfTheHashSet();


            //SortedSetExamples myTest = new SortedSetExamples();
            //myTest.populateTheCollectionByOne(13);
            //myTest.populateTheCollectionByOne(3);
            //myTest.populateTheCollectionByOne(1);
            //Console.Write("The total items on my sorted set is/are: ");
            //myTest.countTheCollection();
            //myTest.printTheCollection();

            //DictionaryExample.populateDictionaryByOne(2, "TWO OF SPADES");
            //DictionaryExample.populateDictionaryByOne(14, "ACE OF CLUBS");
            //DictionaryExample.populateDictionaryByOne(3, "THREE OF SPADES");
            //DictionaryExample.populateDictionaryByOne(9, "NINE OF SPADES");
            //DictionaryExample.printDictionary();
            //DictionaryExample.populateDictionaryByOne(11, "JACK OF HEARTS");
            //// DictionaryExample.populateDictionaryByOne(3, "THREE OF SPADES"); <--- This results to an error because the key is reserved! above
            //DictionaryExample.printSpecificEntryOfDictionary(14);
            //DictionaryExample.countDictionaryEntries();
            //DictionaryExample.removeElementFromDictionaryByKey(2);
            //DictionaryExample.countDictionaryEntries();


            //CountryDictionaryExcercise countryDictionary = new CountryDictionaryExcercise(); // Constructor will give some initial values

            //countryDictionary.printTheCollection();
            //countryDictionary.printTheCollectionByOne("IT");
            //countryDictionary.updateTheCollectionByOne("IT", "Italia");
            //countryDictionary.printTheCollectionByOne("IT");
            //countryDictionary.countTheCollection();
            //countryDictionary.populateTheCollectionByOne("AU", "Australia");
            //countryDictionary.countTheCollection();
            //countryDictionary.removeFromCollectionByOne("AU");
            //countryDictionary.removeFromCollectionByOne("IT");
            //countryDictionary.countTheCollection();

            //TrafficLightEmulator.EmulatorRunner();



        }

        private static void OOD_Week1_Day3()
        {

            Console.WriteLine("OOD Week 1 - Day 3");
            //Console.WriteLine(Math.PI); // An example of static
            Address bankAdddress = new Address("26", "Gilmour St.", "Paisley", "PA1 1EQ");
            Banky bigBank = new Banky("notBankOfScotland", bankAdddress, "55-66-77-88");
            bigBank.sortCode = "11-22-33-44";
            bigBank.addAccount(new ConcreteSavingAccount(1,"Dimitrios", "Koulialis", new Address("26", "Gilmour St.", "Paisley", "PA1 1EQ"), 7, new DateTime(1984, 12, 10), 555.55m, 55.55m));
            bigBank.addAccount(new ConcreteCurrentAccount(2,"Jimmy", "Koulialis", new Address("26", "Gilmour St.", "Paisley", "PA1 1EQ"), 8, new DateTime(1984, 12, 10), 666.66m, 66.66m));

            bigBank.accounts[1].credit(500m);
            bigBank.accounts[2].debitPossible(66.66m);

            bigBank.addAccount(new ConcreteSavingAccount(3,"Dimitrios", "Koulialis", new Address("26", "Gilmour St.", "Paisley", "PA1 1EQ"), 9, new DateTime(1984, 12, 10), 777.77M, 77.77M, DateTime.Now));

            Console.WriteLine(bigBank.ToString());
            Console.WriteLine(bigBank.accounts[2].debitPossible(800.00m)); // This should return false because the debit limit is 666.66.
            
            Console.WriteLine(bigBank.accounts[3].expodentialCredit(300, DateTime.Now));
            Console.WriteLine(bigBank.accounts[3].expodentialCredit(300, new DateTime(1984, 12, 10)));
            Console.WriteLine(bigBank.accounts[3].expodentialCredit(300, DateTime.Now));

            bigBank.accounts[2].procceedDebit(800.00m); // This will call the Account.debitPossible before it procceeds and print not enough credits.
            bigBank.accounts[2].procceedDebit(500.00m); // Likewise
            bigBank.accounts[2].updateOverdraft(10000.00m);
            bigBank.accounts[2].procceedDebit(800.00m);
        }

        private static void OOD_Week1_Day2()
        {

            Console.WriteLine("OOD Week 1 - Day 2");
            Address testCustomersAddress1 = new Address("26", "Gilmour St.", "Paisley", "PA1 1EQ");
            Person testPerson1 = new Person(1, "Dimitrios", "Koulialis", testCustomersAddress1, 7, new DateTime(1984, 12, 10));
            Account testPersons1Acc = new ConcreteSavingAccount(1,"Dimitrios", "Koulialis", testCustomersAddress1, 7, new DateTime(1984, 12, 10), 555.55M);
            Console.WriteLine(testPersons1Acc.ToString());

            PassBy passBy = new PassBy();
            int x = 1;
            int y = 99;
            //Console.WriteLine("\n-=-\nThe original value of X is " + x +" and the original value of Y is " + y);
            passBy.swappingValuesPassByValue(x, y);
            //Console.WriteLine("\n~~~However the orginal value of x and y did not change x = " + x + " and y = " + y);
            passBy.swappingValuesPassByReference(ref x, ref y);
            //Console.WriteLine("\n¬¬¬Amazingly enough the value of x and y changed!!!!!  x = " + x + " and y = " + y);

            passBy.refer(ref x);
            Console.WriteLine("REF KEYWORD " + x);
            passBy.outing(out x);
            Console.WriteLine("OUT KEYWORD " + x);
        }

        private static void OOD_Week1_Day1()
        {

            Console.WriteLine("OOD Week 1 - Day 1");
            Console.WriteLine("I was not present the first day but I guess it went like this... \n Hello World!");
            int thisIsAnInteger = 5;
            Console.WriteLine(thisIsAnInteger);
        }
        #endregion


    }
}
