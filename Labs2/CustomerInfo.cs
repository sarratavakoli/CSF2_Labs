using Block3LabLibrary;
using StudentLib;

namespace Labs2
{
    class CustomerInfo
    {
        static void Main(string[] args)
        {
            //After each data type class has been created,
            //create 2 instances of each class type in the Program.cs
            //file of the console application and print each off to the screen.

            //CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, 
            //bool isPastDue, decimal annualInterestRate)

            //public Customer(string customerId, string firstName,
            //string lastName, ContactInfo contactInformation)

            ContactInfo ci1 = new ContactInfo("3782 NW 118th St.", "Kansas City",
                "MO", "64168", "555-555-5555", "name@emailaddress.com");
            ContactInfo ci2 = new ContactInfo();
            ci2.StreetAddress = "4738 SE 106th St.";
            ci2.City = "Rockville";
            ci2.State = "MD";
            ci2.Zip = "20855";
            ci2.Phone = "333-333-3333";
            ci2.Email = "othername@emailaddress.com";

            Console.WriteLine("Customer class info is below, which includes ContactInfo:\n");
            
            Customer c1 = new Customer("1111", "Sarra", "Tavakoli", ci1);
            Customer c2 = new Customer("2222", "Daniel", "Oskvig", ci2);

            Console.WriteLine(c1 + "\n");
            Console.WriteLine(c2 + "\n\n");

            Console.WriteLine("CreditCardAccount class info is below, which includes ContactInfo:\n");

            CreditCardAccount cc1 = new CreditCardAccount(278439, c1, 53.99m, false, 2.0m);
            CreditCardAccount cc2 = new CreditCardAccount(432789, c2, 21.54m, true, 1.5m);

            Console.WriteLine(cc1 + "\n");
            Console.WriteLine(cc2 + "\n\n");

        }
    }
}