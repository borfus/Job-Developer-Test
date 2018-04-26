using System;

namespace DevTest
{
    [Serializable]
    class Address
    {
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }

        public Address(string street, string city, string state, string zip)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        // Checks for equality for Address class
        public override bool Equals(object obj)
        {
            var address = obj as Address;

            if (address == null)
            {
                return false;
            }

            return (address.Street.Equals(this.Street) && address.City.Equals(this.City) && address.State.Equals(this.State) && address.Zip.Equals(this.Zip));
        }
    }
}
