using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    public class MyMoqClass
    {
        
        public MyMoqClass()
        {
           
        }

        public void MyMoqClassDoesSomethingWith(MyMoqDatabase myDatabase)
        {
            throw NotImplementedException();
        }



        public object MyMoqClassReturnsSomethingWith(MyMoqDatabase myDatabase)
        {
            throw NotImplementedException();
        }


        private Exception NotImplementedException()
        {
            throw new NotImplementedException();
        }
    }
}
