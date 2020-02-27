using Bank;
using BetterBank.Model.AccountBundle;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterBank.Tests
{
    [TestFixture]
    public class AccountTests
    {
        Address jimsAddress, sunnyAddress;
        DateTime jimsBirthday, sunnyBirthday;
        Person jim, sunny;
        CurrentsAccount jimsAccount; 
        SavingsAccount sunnyAccount;

        [SetUp]
        public void Init()
        {
            jimsAddress = new Address("26", "Gilmour St.", "Paisley", "PA1 GG5", "Renfrewshire");
            jimsBirthday = new DateTime(1984, 10, 12);
            jim = new Person(7, "Dimitrios", "Koulialis", jimsAddress, jimsBirthday);
            jimsAccount = new BetterBank.Model.AccountBundle.ConcreteCurrentAccount(jim.key, 500m, jim, 250m);

            sunnyAddress = new Address("2", "Causeyside St.", "Edinburgh", "EH11 4EA", "Sighhill");
            sunnyBirthday = new DateTime(1990, 12, 10);
            sunny = new Person(8, "Sundeep", "Kudurupaka", sunnyAddress, sunnyBirthday);
            sunnyAccount = new BetterBank.Model.AccountBundle.ConcreteSavingsAccount(sunny.key,800m, sunny, 2m);
          }



        [TestCase]
        public void When_NewCurrentAccountIsCreated_TheTotalBalanceIs750_WhenBalanceIs500_AndOverdraftIs250()
        {
            //Act
            decimal expectedTotalBalance = 750m;
            // Assert
            Assert.AreEqual(expectedTotalBalance, jimsAccount.availableTotal);
        }

        [TestCase]
        public void When_NewOverdraft_IsSetForCurrentAccount_By300_TheTotalBalanceIsIncreased_By300()
        {
            // Configure
            decimal previousBalance = jimsAccount.balance - jimsAccount.overdraft;
            decimal newOverdraft = 300m;
            // Act
            jimsAccount.setNewOverdraft(newOverdraft);
            //Assert
            Assert.AreEqual(previousBalance + newOverdraft, jimsAccount.balance);

        }

        [TestCase]
        public void When_NewSavingAccountIsRequestingCreditWithAnInterestOf2_GetBackTwiceTheAmountOfFundsRequested()
        {
            //Configure
            decimal expectedCredit = 600m;
            //Act
            decimal actualCredit = sunnyAccount.credit(300);
            //Assert
            Assert.AreEqual(expectedCredit, actualCredit);
        }


        [TearDown]
        public void Cleanup()
        {
            
        }

    }
}
