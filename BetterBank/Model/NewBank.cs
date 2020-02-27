using System;
using System.Collections.Generic;
using Bank;
using BetterBank.Model.AccountBundle;

namespace BetterBank.Model
{
    public class NewBank
    {
        private string _bankName;
        private Address _address;
        private Dictionary<Int32, Account> _accounts;


        public NewBank(string newBetterBankName, Address newAddress)
        {
            _bankName = newBetterBankName;
            _address = newAddress;
            _accounts = new Dictionary<Int32, Account>();
        }
        

        public void printAllAccounts()
        {
            foreach (KeyValuePair<Int32, Account> kvp in _accounts)
            {
                Console.WriteLine(kvp.Value.ToString());
            }
        }

        // Getters and Setters
        public Dictionary<Int32, Account> accounts
        {
            get
            {
                return _accounts;
            }
            set
            {
                _accounts = value;
            }
        }


        public Address address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }

        }

        public string bankName
        {
            get
            {
                return _bankName;
            }
            set
            {
                _bankName = value;
            }
        }

        public override string ToString()
        {
            string tempString = null;

            foreach (KeyValuePair<Int32,Account> KeyValuePairPrint in _accounts)
                tempString += KeyValuePairPrint.Value.ToString() + "\n";

            return "\nName: " + _bankName + "\nSortCode: " + _address.zip + tempString;

        }

    }
}
