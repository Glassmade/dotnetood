using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzy
    {

        public FizzBuzzy() { }

        public string whatIsThatNumber(int inputNumber)
        {
            string theNumberIs = "";

            switch (true)
            {
                case var isZero when inputNumber == 0:
                    theNumberIs = inputNumber + " is not divisible!!";
                    break;
                case var FizzBuzz when inputNumber % 3 == 0 && inputNumber % 5 == 0:
                    theNumberIs = inputNumber + " is FIZZ BUZZ";
                    break;
                case var Fizz when inputNumber % 3 == 0:
                    theNumberIs = inputNumber + " is FIZZ";
                    break;
                case var Buzz when inputNumber % 5 == 0:
                    theNumberIs = inputNumber + " is BUZZ";
                    break;
                default:
                    theNumberIs = inputNumber + " -=- ";
                    break;
            }
            return theNumberIs;

        }


        public void numberRangeToTestFizzOrBuzzStartingZero(int maximumLoops)
        {
            for (int i=0; i<=maximumLoops; i++)
            {
               Console.WriteLine(this.whatIsThatNumber(i));
            }
        }

    }
}
