using Bank;
using System;


namespace BetterBank.Model.AccountBundle
{
    public class ConcreteSavingsAccount : SavingsAccount
    {

        public ConcreteSavingsAccount(Int32 bindKey, decimal balance, Person owner, decimal interest) : base(bindKey, balance, owner, interest) { }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
