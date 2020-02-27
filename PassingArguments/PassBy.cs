using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassingArguments
{
    public class PassBy
    {
       public PassBy() { }

       public void swappingValuesPassByValue(int x, int y)
        {
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("\n @~@~@~@~@~@~@~~@~@~@ Inside the PassBy Class @~@~@~@~@~@~@~~@~@~@");
            Console.WriteLine("\n This is the swappingValuesByPassByValue x = " + x + " and y =" + y);
            Console.WriteLine("\n @~@~@~@~@~@~@~~@~@~@ Exiting the PassBy Class @~@~@~@~@~@~@~~@~@~@");
        }

        public void refer(ref int x) //Does not expect to be defined within the method.
        {
            x += x;
        }

        public void outing(out int x) // Expects to be defined within the method.
        {
            x = 0;
            x += x;
        }

        public void swappingValuesPassByReference(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
