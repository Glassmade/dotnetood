namespace Bank
{
    public class Address
    {

        public string number { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string county { get; set; } // Optional
        public string zip { get; set; }

        public Address(string number, string street, string city, string zip)
        {
            this.number = number;
            this.street = street;
            this.city = city;
            this.zip = zip;
        }

        public Address(string number, string street, string city, string zip,string county) : this(number, street, city, zip)
        {
            this.county = county;
        }

        public override string ToString()
        {
            if (county == null)
                return "\n-Address:\n--Number: " + number + "\n--Street: " + street + "\n--City: " + city + "\n--PostCode: " + zip;
            else
                return "\n-Address:\n--Number: " + number + "\n--Street: " + street + "\n--City: " + city + "\n--County: " + county + "\n--PostCode: " + zip;
        }
    }
}
