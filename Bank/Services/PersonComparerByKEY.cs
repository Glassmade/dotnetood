using System.Collections;

namespace Bank.Services
{
    class PersonComparerByKEY : IComparer
    {
        int IComparer.Compare(object inputPerson1, object inputPerson2)
        {
            Person person1 = (Person)inputPerson1;
            Person person2 = (Person)inputPerson2;
            if (person1.key > person2.key)
                return 1;
            if (person1.key < person2.key)
                return -1;
            else
                return person1.lastName.CompareTo(person2.lastName);

        }
    }
}
