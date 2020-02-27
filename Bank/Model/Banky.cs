using Bank.Model.AccountBundle;
using System;
using System.Collections.Generic;

namespace Bank
{
    public class Banky
    {

        public string name { get { return _name; } set { _name = value; } }
        public Address address { get { return _address; } set { _address = value; } }
        public string sortCode { get { return _sortCode; } set { _sortCode = value; } }
        //public Account[] accounts { get { return _accounts; } set { _accounts = value; } }
        public Dictionary<Int32, Account> accounts = new Dictionary<Int32, Account>();

        private string _name;
        private Address _address;
        private string _sortCode;
        private Account[] _accounts = new Account[20];

        public Banky(string input_name, Address input_address, string input_sortCode)
        {
            _name = input_name;
            _address = input_address;
            _sortCode = input_sortCode;
        }
        
        public void addAccount(Account inputAccount)
        {
            try
            {
                accounts.Add(inputAccount.key, inputAccount);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void addSpecialAccount(IHolidaysAccount inputAccount)
        {
            for (int i = 0; i <= _accounts.Length - 1; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = (Account)inputAccount;
                    break;
                }
            }

        }

        public int countAccounts()
        {
            int returnedCounter = 0;
           foreach(Account countAccount in _accounts)
            {
                if (countAccount != null)
                {
                    returnedCounter++;
                }
            }
            return returnedCounter;
        }

        public override string ToString()
        {
            string tempString =null;
            foreach (Account printAccount in _accounts)
            {
                if (printAccount != null)
                    tempString += printAccount.ToString()+"\n";
            }
            return "\nName: " + _name  + "\nSortCode: " + _sortCode + tempString;
                
        }
    }
}
