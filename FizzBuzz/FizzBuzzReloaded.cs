namespace FizzBuzz
{
    public class FizzBuzzReloaded
    {
        public FizzBuzzReloaded(){}


        public string letmeCheckTheNumber(int input)  
        {
       
            string whatTheNumberIs;
            if (isZero(input))
                whatTheNumberIs = input + " is zero";
            else if (isFizzBuzz(input))
                whatTheNumberIs = input + " is FizzBuzz";
            else if (isFizz(input))
                whatTheNumberIs = input + " is Fizz";
            else if (isBuzz(input))
                whatTheNumberIs = input + " is Buzz";
            else 
                whatTheNumberIs = input + " is neither";
            return whatTheNumberIs;
        }


        public bool isFizz(int checkForFizz)
        {
            return checkForFizz % 3 == 0;
        }

        public bool isBuzz(int checkForBuzz)
        {
            return checkForBuzz % 5 == 0;
        }

        public bool isZero(int checkZero)
        {
            if (checkZero == 0)
                return true;
            else
                return false;
        }

        public bool isFizzBuzz(int checkForFizzBuzz)
        {
            return isFizz(checkForFizzBuzz) && isBuzz(checkForFizzBuzz);
        }

       

    }
}
