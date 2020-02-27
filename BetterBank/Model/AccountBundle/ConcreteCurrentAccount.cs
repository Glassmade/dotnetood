using Bank;
using System;

namespace BetterBank.Model.AccountBundle
{
    public class ConcreteCurrentAccount : CurrentsAccount
    {

        public ConcreteCurrentAccount(Int32 bindKey, decimal balance, Person owner, decimal overdraft) : base(bindKey, balance, owner, overdraft){}

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
