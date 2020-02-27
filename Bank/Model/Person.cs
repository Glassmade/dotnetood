using System;
using System.Collections;
using Bank.Services;

namespace Bank
{
    public class Person : IComparable
    {

        #region Fields
        public Int32 key { get; set; }
        public string firstName { get; set; }
        public string lastName {get; set; }
        public Address address {get; set; }
        public int accNo { get; set; }
        public DateTime dateOfBirth { get; set; }
        #endregion

        #region Constructors
        public Person() { }

        public Person(Int32 inputKey, string firstName, string lastName, Address address, int accNo, DateTime dateOfBirth)
        {
            this.key = inputKey;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.accNo = accNo;
            this.dateOfBirth = dateOfBirth;
        }

        public Person(Int32 inputKey, string firstName, string lastName)
        {
            this.key = inputKey;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.accNo = accNo;
            this.dateOfBirth = dateOfBirth;
        }
        public Person(Int32 inputKey, string firstName, string lastName, Address address, DateTime dateOfBirth)
        {
            this.key = inputKey;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.accNo = accNo;
            this.dateOfBirth = dateOfBirth;
        }
        #endregion

        #region To String methods
        public override string ToString()
        {
            return "\nFirstName: " + firstName + "\nLastName: " + lastName + address.ToString() +  "\nDate of Birth: " + dateOfBirth.ToShortDateString();
        }

        public string newToString()
        {
            return "\n ID: " + key + "\nFirstName: " + firstName + "\nLastName: " + lastName;
        }
        #endregion

        #region Compare methods
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Person otherPerson = obj as Person;
            if (otherPerson != null)
                return this.key.CompareTo(otherPerson.key);
            else
                throw new ArgumentException("Object is not a Person");
        }

        public static IComparer PersonComparerByKey()
        {
            return (IComparer)new PersonComparerByKEY();
        }
        #endregion


    }
}
