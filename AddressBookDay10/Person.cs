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
        public static List<Person> people = new List<Person>();
        public Person()     //Creating default constructor
        {

        }
        //Creating contructor for address book
        public Person(string FirstName, string LastName, string PhoneNumber, string Address, string City, string State, string EmailID)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.City = City;
            this.State = State;
            this.EmailID = EmailID;
        }
        public static void AddPerson(int numContact)          //Creating method for taking user inputs
        {
            for (int i = 0; i < numContact; i++)
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
                people.Add(person);
            }
        }
        public static void PrintPerson()            //Creating method to display persons details
        {
            foreach (Person person in people)
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
        public void editContact(string name)
        {
            bool input = false;
            Console.WriteLine("Enter:\n1:Edit for Firstname\n2:Edit for LastName\n3:Edit for PhoneNumber\n4:Edit for Address\n5:Edit for City\n6:Edit for State\n7:Edit for EmailId");
            int option = Convert.ToInt32(Console.ReadLine());
            foreach(Person person in people)
            {
                if (person.FirstName == name)
                {
                    input = true;
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter current first name: ");
                            string currentFirstName = Convert.ToString(Console.ReadLine());
                            person.FirstName = currentFirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter current last name: ");
                            string currentLastName = Convert.ToString(Console.ReadLine());
                            person.LastName = currentLastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter current Phone Number: ");
                            string currentPhoneNumber = Convert.ToString(Console.ReadLine());
                            person.PhoneNumber = currentPhoneNumber;
                            break;
                        case 4:
                            Console.WriteLine("Enter current Address: ");
                            string currentAddress = Convert.ToString(Console.ReadLine());
                            person.Address = currentAddress;
                            break;
                        case 5:
                            Console.WriteLine("Enter current City: ");
                            string currentCity = Convert.ToString(Console.ReadLine());
                            person.City = currentCity;
                            break;
                        case 6:
                            Console.WriteLine("Enter current State: ");
                            string currentState = Convert.ToString(Console.ReadLine());
                            person.State = currentState;
                            break;
                        case 7:
                            Console.WriteLine("Enter current EmailId: ");
                            string currentEmailID= Convert.ToString(Console.ReadLine());
                            person.EmailID = currentEmailID;
                            break;
                        default:
                            Console.WriteLine("Please enter valid option");
                            break;
                    }
                }
            }
            if(input = false)
                Console.WriteLine("First name is not found");
            Person.PrintPerson();
        }
    }
}
