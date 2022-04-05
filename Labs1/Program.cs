//Complete the lab sets outlined above.
//Note that you will need to add a separate Class Library project for the data type classes. 
//You will also need to add a reference the class library project in the console application project.
//After each data type class has been created, create 2 instances of each class type in the Program.cs
//file of the console application and print each off to the screen.

using StudentLib;

namespace Labs1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Lab 1";
            Console.WriteLine(" ***** Lab 1 *****\n");

            //student 1 - unqualified constructor
            Student s1 = new Student();
            s1.FirstName = "Sarra";
            s1.LastName = "Tavakoli";
            s1.Id = "693894";
            s1.Gpa = 4.0f;
            Console.WriteLine(s1 + "\n");

            //student 2 - qualified constructor
            Student s2 = new Student("Daniel", "Oskvig", "278467", 4.0f);
            Console.WriteLine(s2 + "\n");

            //vehicle 1 - qualified constructor
            Vehicle v1 = new Vehicle("Toyota", "Corolla", 1996, 2000f);
            Console.WriteLine(v1 + "\n");

            //vehicle 2 - unqualified constructor
            Vehicle v2 = new Vehicle();
            v2.Make = "Nissan";
            v2.Model = "Sentra";
            v2.Year = 2021;
            v2.Weight = 2500f;
            Console.WriteLine(v2 + "\n");

            //Login 1 - unqualified constructor
            Login l1 = new Login();
            l1.Username = "JennyZ";
            l1.Password = "JennyRocks";
            Console.WriteLine(l1 + "\n");

            //login 2 - qualified constructor
            Login l2 = new Login("IronMan", "Pepperpots");
            Console.WriteLine(l2 + "\n");

            //contactinfo 1 - qualified constructor
            ContactInfo c1 = new ContactInfo("3782 NW 118th St.", "Kansas City", 
                "MO", "64168", "555-555-5555", "name@emailaddress.com");
            Console.WriteLine(c1 + "\n");

            //contactinfo 2 - unqualified constructor
            ContactInfo c2 = new ContactInfo();
            c2.StreetAddress = "4738 SE 106th St.";
            c2.City = "Rockville";
            c2.State = "MD";
            c2.Zip = "20855";
            c2.Phone = "333-333-3333";
            c2.Email = "othername@emailaddress.com";
            Console.WriteLine(c2 + "\n");

        }
    }
}