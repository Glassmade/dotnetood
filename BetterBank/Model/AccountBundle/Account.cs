using Bank;
using System;

namespace BetterBank.Model.AccountBundle
{
    public abstract class Account 
    {
        public Int32 bindKey;
        public decimal balance;
        public const int ZEROBALANCE = 0;
        public Person owner;

        public Account(Int32 bindKey, Person assignedOwner, decimal startingBalance)
        {
            this.bindKey = assignedOwner.key;
            this.owner = assignedOwner;
            this.balance = startingBalance;
        }

        public virtual decimal credit(decimal inputedFunds)
        {
            return inputedFunds;
        }

        public virtual void debit(decimal inputedFunds)
        {
            if (balance - inputedFunds < ZEROBALANCE)
                Console.WriteLine("Not enough balance");
            else
            { 
                balance -= inputedFunds;
                Console.WriteLine("Your new balance is " + balance);
            }
        }

        public override string ToString()
        {
            return "\nAccount Owner: " + owner.ToString() + "\nAccount Number: " + bindKey + "\nBalance: " + balance;
        }
    }
}
