using System;

namespace Bank.Model.AccountBundle
{
    public class ConcreteSavingAccount : Account
    {
        private decimal _interest = 0;
        public decimal interest { get { return _interest; } set { _interest = interest; } }
        private DateTime _releaseFundsDate;
        public DateTime realeseFundsDate { get { return _releaseFundsDate;  } set { _releaseFundsDate = realeseFundsDate; }  }

        public ConcreteSavingAccount(Int32 key, string firstName, string lastName, Address address, int accNo, DateTime dateOfBirth, decimal balance) : base(key, firstName, lastName, address, accNo, dateOfBirth, balance)
        {
        }

        public ConcreteSavingAccount(Int32 key, string firstName, string lastName, Address address, int accNo, DateTime dateOfBirth, decimal balance, decimal inputInterest) : base(key, firstName, lastName, address, accNo, dateOfBirth, balance)
        {
            this._interest = inputInterest;
        }

        public ConcreteSavingAccount(Int32 key, string firstName, string lastName, Address address, int accNo, DateTime dateOfBirth, decimal balance, decimal inputInterest, DateTime inputDateTime) : base(key, firstName, lastName, address, accNo, dateOfBirth, balance)
        {
            this._interest = inputInterest;
            this._releaseFundsDate = inputDateTime;
        }

        public override decimal credit(decimal funds)
        {
            return balance += funds * _interest;
        }

        public new bool debitPossible(decimal funds)
        {
            return base.debitPossible(funds);
        }

        public new void procceedDebit(decimal funds)
        {
            base.procceedDebit(funds);
        }

        public override string ToString()
        {
            return base.ToString() + "\n The overdraft for this Saving's account is: " + interest;
        }

        public override void updateOverdraft(decimal byAnAmountOf)
        {
            throw new NotImplementedException();
        }
    }
}
