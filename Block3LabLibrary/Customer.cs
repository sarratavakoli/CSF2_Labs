using StudentLib;

namespace Block3LabLibrary
{
    public class Customer
    {
        //fields
        private string _customerId;
        private string _firstName;
        private string _lastName;
        private ContactInfo _contactInformation;

        //properties
        public string CustomerId
            { get { return _customerId; } set { _customerId = value; } }
        public string FirstName
            { get { return _firstName; } set { _firstName = value; } }
        public string LastName
            { get { return _lastName; } set { _lastName = value; } }
        public ContactInfo ContactInformation
        { get { return _contactInformation;  } set { _contactInformation = value; } }

        //constructors
        public Customer(string customerId, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }

        //methods
        public override string ToString()
        {
            return string.Format($"Customer {CustomerId}: {FirstName} {LastName}" +
                $"\n{ContactInformation}");
        }



    }
}
