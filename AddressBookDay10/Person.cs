using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public string AddressBookName { get; set; }

        public static List<Person> people = new List<Person>();
        public static Dictionary<string, Person> contactDictionary;
        public Person()
        {
           contactDictionary = new Dictionary<string, Person>();
        }
        //Creating contructor for address book
        public Person(string AdressBookName,string FirstName, string LastName, string PhoneNumber, string Address, string City, string State, string EmailID)
        {
            this.AddressBookName = AdressBookName;
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
        public void AddDetails(string adressBookName, string firstName, string lastName, string phoneNumber, string address, string city, string state, string emailId)
        {
            Person newContact = new Person(adressBookName, firstName, lastName, phoneNumber, address, city, state, emailId);
            contactDictionary.Add(adressBookName, newContact);
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
        public static void AddPerson1(string addressBookName, int numContact)          //Creating method for taking user inputs
        {
            for (int i = 0; i < numContact; i++)
            {
            
                Person person = new Person();
                Console.WriteLine("Enter the Address Book name");
                person.AddressBookName = addressBookName;
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
                contactDictionary.Add(person.AddressBookName, person);
            }
        }
        public static void PrintPerson1()            //Creating method to display persons details
        {
            foreach (var person in contactDictionary)
            {
                Console.WriteLine("Here is the address book of Person");
                Console.WriteLine("Address Book Name: " + person.Value.AddressBookName);
                Console.WriteLine("First Name: " + person.Value.FirstName);
                Console.WriteLine("Last Name: " + person.Value.LastName);
                Console.WriteLine("Phone Number: " + person.Value.PhoneNumber);
                Console.WriteLine("Address: " + person.Value.Address);
                Console.WriteLine("City: " + person.Value.City);
                Console.WriteLine("State: " + person.Value.State);
                Console.WriteLine("EmailId: " + person.Value.EmailID);
                Console.WriteLine("---------------------------------------");
            }
        }


        public void editContact(string name)        //Creating Method to edit contact
        {
            bool input = false;
            Console.WriteLine("Enter:\n1:Edit for Firstname\n2:Edit for LastName\n3:Edit for PhoneNumber\n4:Edit for Address\n5:Edit for City\n6:Edit for State\n7:Edit for EmailId");
            int option = Convert.ToInt32(Console.ReadLine());
            foreach (Person person in people)
            {
                if (person.FirstName == name)
                {
                    input = true;
                    switch (option)         //Switch case for editing parameter
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
                            string currentEmailID = Convert.ToString(Console.ReadLine());
                            person.EmailID = currentEmailID;
                            break;
                        default:
                            Console.WriteLine("Please enter valid option");
                            break;
                    }
                }
            }
            if (input = false)
                Console.WriteLine("First name is not found");
            Person.PrintPerson();
        }
        public void editContact1(string firstName)        //Creating Method to edit contact
        {
            bool input = false;
            Console.WriteLine("Enter:\n1:Edit for Firstname\n2:Edit for LastName\n3:Edit for PhoneNumber\n4:Edit for Address\n5:Edit for City\n6:Edit for State\n7:Edit for EmailId");
            int option = Convert.ToInt32(Console.ReadLine());
            foreach (var person in contactDictionary)
            {
                if (person.Key == firstName)
                {
                    input = true;
                    switch (option)         //Switch case for editing parameter
                    {
                        case 1:
                            Console.WriteLine("Enter current first name: ");
                            string currentFirstName = Convert.ToString(Console.ReadLine());
                            person.Value.FirstName = currentFirstName;
                            break;
                        case 2:
                            Console.WriteLine("Enter current last name: ");
                            string currentLastName = Convert.ToString(Console.ReadLine());
                            person.Value.LastName = currentLastName;
                            break;
                        case 3:
                            Console.WriteLine("Enter current Phone Number: ");
                            string currentPhoneNumber = Convert.ToString(Console.ReadLine());
                            person.Value.PhoneNumber = currentPhoneNumber;
                            break;
                        case 4:
                            Console.WriteLine("Enter current Address: ");
                            string currentAddress = Convert.ToString(Console.ReadLine());
                            person.Value.Address = currentAddress;
                            break;
                        case 5:
                            Console.WriteLine("Enter current City: ");
                            string currentCity = Convert.ToString(Console.ReadLine());
                            person.Value.City = currentCity;
                            break;
                        case 6:
                            Console.WriteLine("Enter current State: ");
                            string currentState = Convert.ToString(Console.ReadLine());
                            person.Value.State = currentState;
                            break;
                        case 7:
                            Console.WriteLine("Enter current EmailId: ");
                            string currentEmailID = Convert.ToString(Console.ReadLine());
                            person.Value.EmailID = currentEmailID;
                            break;
                        default:
                            Console.WriteLine("Please enter valid option");
                            break;
                    }
                }
            }
            if (input = false)
                Console.WriteLine("First name is not found");
            Person.PrintPerson1();
        }
        public void deleteContact(string name)      //Creating method for delete contact
        {
            bool flag = false;
            foreach (Person person1 in people)
            {
                if (person1.FirstName == name)
                {
                    flag = true;
                    people.Remove(person1);
                    Console.WriteLine("The contact is successfully removed");
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("The contact is not found");
        }
        public void deleteContact1(string firstname)      //Creating method for delete contact
        {
            bool flag = false;
            foreach (var person1 in contactDictionary)
            {
                if (person1.Key == firstname)
                {
                    flag = true;
                    contactDictionary.Remove(person1.Key);
                    Console.WriteLine("The address book of person after removed");
                    break;
                }
            }
            if (flag == false)
                Console.WriteLine("The contact is not found");
        }
        public static void AddressBook()        //Creating AddressBook method
        {
            Person dic = new Person();
            Console.WriteLine("1:Add contact\n2:Display Contact\n3:Edit Contact\n4:Remove Contact");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the number of address book you want to make");
                        int bookNum = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < bookNum; i++)
                        {
                            Console.WriteLine("Enter the name of addressbook");
                            string addressBookName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter the number of contact you want to make in {0}",addressBookName);
                            int numContact = Convert.ToInt32(Console.ReadLine());
                            AddPerson1(addressBookName, numContact);
                            PrintPerson1();
                        }
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Enter the name of addressbook");
                        string addressBookName = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter the number of contact you want to make in {0}", addressBookName);
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        AddPerson1(addressBookName, numContact);
                        PrintPerson1();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Enter the name of addressbook");
                        string addressBookName = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Enter the number of contact you want to make in {0}", addressBookName);
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        AddPerson1(addressBookName, numContact);
                        PrintPerson1();
                        Console.WriteLine("Enter First Name of the Contact you want to edit");
                        string firstName = Console.ReadLine();
                        dic.deleteContact1(firstName);
                        PrintPerson1();
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Enter the number of adress book you want to make");
                        int boolNum = Convert.ToInt32(Console.ReadLine());
                        for (int i =0; i<boolNum; i++)
                        {
                            Console.WriteLine("Enter the name of addressbook");
                            string addressBookName = Convert.ToString(Console.ReadLine());
                            Console.WriteLine("Enter the number of contact you want to make in {0}", addressBookName);
                            int numContact = Convert.ToInt32(Console.ReadLine());
                            AddPerson1(addressBookName, numContact);
                            PrintPerson1();
                            Console.WriteLine("Enter First name to remove the contact");
                            string firstName = Console.ReadLine();
                            dic.deleteContact1(firstName);
                            PrintPerson1();

                        }

                    }
                    break;
            }
        }
    }
}