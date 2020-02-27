using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetood
{
    public class MyGenericSerialization
    {

        public MyGenericSerialization()
        {
        }

        public string serializeMyObject(Object inputedObject)
        {
            string json = JsonConvert.SerializeObject(inputedObject, Formatting.Indented);
            return json;
        }



    }
}
