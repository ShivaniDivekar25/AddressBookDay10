using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookDay10
{
    public class Person         //Creating class
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string EmailID { get; set; }
        public string UserName { get; set; }
        public string ContactNumber { get; set; }
        public string EditNumber { get; set; }
        public static List<Person> People = new List<Person>();

        public static void AddPerson()          //Creating method for taking user inputs
        {
            Person person = new Person();
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();
            Console.WriteLine("Enter the City: ");
            person.City = Console.ReadLine();
            Console.WriteLine("Enter the state: ");
            person.State = Console.ReadLine();
            Console.WriteLine("Enter the EmailId");
            person.EmailID = Console.ReadLine();
            People.Add(person);
        }
        public static void PrintPerson()            //Creating method to display persons details
        {
            foreach (Person person in People)
            {
                Console.WriteLine("Here is the address book of Person");
                Console.WriteLine("First Name: " + person.FirstName);
                Console.WriteLine("Last Name: " + person.LastName);
                Console.WriteLine("Phone Number: " + person.PhoneNumber);
                Console.WriteLine("Address: " + person.Address);
                Console.WriteLine("City: " + person.City);
                Console.WriteLine("State: " + person.State);
                Console.WriteLine("EmailId: " + person.EmailID);
                Console.WriteLine("---------------------------------------");
            }
        }

    }
}
