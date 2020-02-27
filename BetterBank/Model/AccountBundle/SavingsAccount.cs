using Bank;
using Bank.Model.AccountBundle;
using System;


namespace BetterBank.Model.AccountBundle
{
    public abstract class SavingsAccount : Account, IHolidaysAccount
    {
        public decimal interest;

        public SavingsAccount(Int32 bindKey, decimal balance, Person owner, decimal inputedInterest) : base(bindKey, owner, balance)
        {
            this.interest = inputedInterest;
        }

        public override decimal credit(decimal inputedFunds)
        {

            return base.credit(inputedFunds)*interest;
        }

        public decimal expodentialCredit(decimal inputFunds, DateTime inputDateTime)
        {
            if (inputDateTime >= DateTime.Now)
            {
                this.balance += balance += inputFunds * 2;
                return this.balance;
            }
            else
            {
                Console.WriteLine("Your credits for your holidays savings account are not available yet");
                return this.balance; ;
            }
        }
    }
}
