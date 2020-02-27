using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTester
    {
        FizzBuzzy myFizzBuzz;
        FizzBuzzReloaded reloaded;

        [SetUp]
        public void Init()
        {
            myFizzBuzz = new FizzBuzzy();
            reloaded = new FizzBuzzReloaded();
        }

        [TestCase]
        public void When_ZeroIsGiven_WeGetIs_NOT_Divisible_Message()
        {
            int zero = 0;
            string expectedMessage = zero+" is not divisible!!";

            Assert.AreEqual(expectedMessage, myFizzBuzz.whatIsThatNumber(zero));
        }

        [TestCase]
        public void When_ThreeIsGiven_WeGetIs_FIZZ_Message()
        {
            int three = 3;
            string expectedMessage = three + " is FIZZ";
            Assert.AreEqual(expectedMessage, myFizzBuzz.whatIsThatNumber(three));
        }

        [TestCase]
        public void When_FiveIsGiven_WeGetIs_BUZZ_Message()
        {
            int five = 5;
            string expectedMessage = five + " is BUZZ";
            Assert.AreEqual(expectedMessage, myFizzBuzz.whatIsThatNumber(five));
        }

        [TestCase]
        public void When_FifteenIsGiven_WeGetIs_FIZZBUZZ_Message()
        {
            int fifteen = 15;
            string expectedMessage = fifteen + " is FIZZ BUZZ";
            Assert.AreEqual(expectedMessage, myFizzBuzz.whatIsThatNumber(fifteen));
        }

        [TestCase(2)]
        [TestCase(4)]
        [TestCase(223)]
        [TestCase(3877)]
        public void When_AnyOtherNumberIsGiven_ThatIsNeither_WeGetSpecialDecoratedMessage(int inputCaseNumber)
        {
            string expectedMessage = inputCaseNumber +" -=- "; // <-- Special Decorated Message.
            Assert.AreEqual(expectedMessage, myFizzBuzz.whatIsThatNumber(inputCaseNumber));
        }

        [TestCase]
        public void When_Three_Is_Given_IsFizz_Comes_Back_True_And_Buzz_FizzBuzzComeBack_FALSE()
        {
            int three = 3;
            Assert.IsTrue(reloaded.isFizz(three));
            Assert.IsFalse(reloaded.isBuzz(three));
            Assert.IsFalse(reloaded.isFizzBuzz(three));
        }

        public void When_ZERO_IsGiven_isZero_ComesBack_TRUE()
        {
            int zero = 0;
            Assert.IsTrue(reloaded.isZero(zero));
        }

        [TestCase]
        public void When_isFizzComesBackTrue_ISFIZZ_StringIsReturned()
        {
            int three = 3;
            string expectedMessage = three + " is Fizz";
            Assert.AreEqual(expectedMessage, reloaded.letmeCheckTheNumber(three));
        }

        [TestCase]
        public void When_Five_Is_Given_IsBuzz_ComeBackAsTrue_And_TheOtherComeBack_FALSE()
        {
            int five = 5;
            Assert.IsFalse(reloaded.isFizz(five));
            Assert.IsTrue(reloaded.isBuzz(five));
            Assert.IsFalse(reloaded.isFizzBuzz(five));
        }

        [TestCase]
        public void When_isBuzzComesBackTrue_ISBUZZ_StringIsReturned()
        {
            int five = 5;
            string expectedMessage = five + " is Buzz";
            Assert.AreEqual(expectedMessage, reloaded.letmeCheckTheNumber(five));
        }

        [TestCase]
        public void When_bothiFizz_AND_isBuzzComesBackTrue_IS_FIZZBUZZ_StringIsReturned()
        {
            int fifteen = 15;
            string expectedMessage = fifteen + " is FizzBuzz";
            Assert.AreEqual(expectedMessage, reloaded.letmeCheckTheNumber(fifteen));
        }

        [TestCase]
        public void When_Fifteen_IsGiven_All_OurBooleanMethodsComeBack_TRUE()
        {
            int fifteen = 15;
            Assert.IsTrue(reloaded.isFizzBuzz(fifteen));
            Assert.IsTrue(reloaded.isFizz(fifteen));
            Assert.IsTrue(reloaded.isBuzz(fifteen));
        }

        
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(223)]
        [TestCase(3877)]
        public void When_AnyOtherNumberThatIsNeitherFizzOrBuzz_IS_NEITHER_String_IsReturnend(int testCaseNumber)
        {
            string expectedMessage = testCaseNumber + " is neither";
            Assert.AreEqual(expectedMessage, reloaded.letmeCheckTheNumber(testCaseNumber));    
        }

        [TestCase]
        public void When_ZERO_is_Given_IS_ZERO_String_IsReturned()
        {
            int zero = 0;
            string expectedMessage = zero+ " is zero";
            Assert.AreEqual(expectedMessage, reloaded.letmeCheckTheNumber(zero));
        }

        [TestCase]
        public void WhenNoNumberIsGiven_ExceptionIsThrown()
        {
            Assert.Throws<FormatException>(() => Int32.Parse("IamNot_A_number"));
        }

    }
}
