using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsExamples
{
    public class SortedSetExamples : BasicControls<int>
    {

        public SortedSet<int> mySortedSet = new SortedSet<int>();


        public void countTheCollection()
        {
            Console.WriteLine(mySortedSet.Count);
        }

        public void populateTheCollectionByOne(int inputedInteger)
        {
            mySortedSet.Add(inputedInteger);
        }

        public void printTheCollection()
        {
            foreach(int printedInteger in mySortedSet){
                Console.WriteLine(printedInteger);
            }
        }
    }
}
