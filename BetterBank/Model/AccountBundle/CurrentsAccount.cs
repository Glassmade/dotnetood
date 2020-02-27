using Bank;
using System;

namespace BetterBank.Model.AccountBundle
{
    public abstract class CurrentsAccount : Account
    {
        public decimal overdraft;
        public decimal availableTotal;

        public CurrentsAccount(Int32 bindKey, decimal balance, Person owner, decimal inputedOverdraft) : base(bindKey, owner, balance)
        {
            this.overdraft = inputedOverdraft;
            this.availableTotal = this.balance + this.overdraft;
        }

        public override decimal credit(decimal inputedFunds)
        {
            return base.credit(inputedFunds);
        }

        public override void debit(decimal inputedFunds)
        {
            base.debit(inputedFunds);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public void setNewOverdraft(decimal newOverdraft)
        {
            this.balance -= this.overdraft;
            this.overdraft = newOverdraft;
            this.balance += this.overdraft;
        }

        public override string ToString()
        {
            return base.ToString() + "\nOverdraft: " + overdraft + " (already added to total balance)";
        }
    }
}
