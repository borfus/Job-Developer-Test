using System;

namespace DevTest
{
    [Serializable]
    class Company : Information<Company>
    {
        public string Name { get; }
        public Address Address { get; }

        public Company(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        // Checks for equality for Company class
        public override bool Equals(object obj)
        {
            var company = obj as Company;

            if (company == null)
            {
                return false;
            }

            return company.Name.Equals(this.Name) && company.Address.Equals(this.Address);
        }
    }
}
