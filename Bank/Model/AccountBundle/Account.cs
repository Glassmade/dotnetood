using System;

namespace Bank.Model.AccountBundle
{
    public abstract class Account : Person, IHolidaysAccount, ICurrentAccount
    {
        public decimal balance;

        public Account(Int32 key, string firstName, string lastName, Address address, int accNo, DateTime dateOfBirth, decimal balance) : base(key, firstName,lastName,address,accNo,dateOfBirth)
        {
            this.balance = balance;
        }

        public virtual decimal credit(decimal funds)
        {
            return balance += funds;
        }

        public virtual bool debitPossible(decimal funds)
        {
            bool theDebitResult = true;

            if (balance - funds < 0)
                theDebitResult = false;
            else
                balance -= funds;

            return theDebitResult;
        }

        public virtual void procceedDebit(decimal funds) {
            if (debitPossible(funds))
            {
                Console.WriteLine("You have subtracted " + funds + " from your balance " + balance);
                balance -= funds;
                Console.WriteLine("New balance: " + balance);
            }
            else
            {
                Console.WriteLine("Sorry, Not enough overdraft");
            }
        }

        public decimal expodentialCredit(decimal inputFundz, DateTime inputDateTimez)
        {
            if (inputDateTimez >= DateTime.Now)
            {
                return balance += inputFundz * 2;
            }
            else
            {
                Console.WriteLine("Your credits for your holidays savings account are not available yet");
                return balance;
            }

        }



        public override string ToString()
        {
            return base.ToString() +"\n-Account:" + "\n--AccNumber: " + base.accNo + "\n--AccBalance: " + balance; 
        }

        public abstract void updateOverdraft(decimal byAnAmountOf);
    }

}
