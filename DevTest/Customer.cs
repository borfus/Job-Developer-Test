using System;

namespace DevTest
{
    [Serializable]
    class Customer : Information<Customer>
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Address Address { get;}

        public Customer(string firstName, string lastName, Address address)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
        }

        // Checks for equality for Customer class
        public override bool Equals(object obj)
        {
            var customer = obj as Customer;

            if (customer == null)
            {
                return false;
            }

            return (customer.FirstName.Equals(this.FirstName) && customer.LastName.Equals(this.LastName) && customer.Address.Equals(this.Address));
        }
    }
}
