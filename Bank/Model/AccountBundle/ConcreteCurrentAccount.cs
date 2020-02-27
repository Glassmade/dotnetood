using System;


namespace Bank.Model.AccountBundle
{
    public class ConcreteCurrentAccount : Account
    {

        public decimal overdraft { get { return _overdraft; } set { _overdraft = overdraft; } }
        private decimal _overdraft;

        public ConcreteCurrentAccount(Int32 key, string firstName, string lastName, Address address, int accNo, DateTime dateOfBirth, decimal balance) : base(key, firstName, lastName, address, accNo, dateOfBirth, balance)
        {
        }

        public ConcreteCurrentAccount(Int32 key, string firstName, string lastName, Address address, int accNo, DateTime dateOfBirth, decimal balance, decimal inputOverdraft) : base(key, firstName, lastName, address, accNo, dateOfBirth, balance)
        {
            this._overdraft = inputOverdraft;
        }

        public new decimal credit(decimal funds)
        {
            return base.credit(funds);
        }

        public override bool debitPossible(decimal funds)
        {
            bool theDebitResult = true;

            if ((balance + _overdraft) - funds < 0)
                theDebitResult = false;

            return theDebitResult;
        }

        public override void procceedDebit(decimal funds)
        {
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




        public override string ToString()
        {
            return base.ToString() + "\n The overdraft for this Saving's account is: " + overdraft;

        }

        public override void updateOverdraft(decimal byAnAmountOf)
        {
            _overdraft = Decimal.Add(overdraft, byAnAmountOf);
            Console.WriteLine("New Overdraft totalis " + Decimal.Add(_overdraft, balance));
        }
    }
}
