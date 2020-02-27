using System;
using Bank;
using Newtonsoft.Json;

namespace dotnetood
{
    public static class MySerialization
    {

        static Address jimsAddress = new Address("26", "Gilmour St.", "Paisley", "PA1 2BS", "Renfrewshire");
        static DateTime jimsBirthday = new DateTime(1984, 10, 12);
        static Person jim = new Person(7, "Dimitrios", "Koulialis", jimsAddress, jimsBirthday);

        public static string serializeMe() { 
            string json = JsonConvert.SerializeObject(jim, Formatting.Indented);
            return json;
        }

    }
}
