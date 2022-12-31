using System;

namespace AddressBookDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start
            Console.WriteLine("Welcome to Address Book Program!");
            Console.WriteLine("Entern\n1:Ability to create Contacts in AddressBook\n2:Ability to add new coontact to AddressBook\n3:Edit contact in AddressBook");
            int option = Convert.ToInt32(Console.ReadLine());       //Taking user input
            //Calling methods using Switch case for UC1,UC2 and UC3 
            switch (option)
            {
                case 1:        
                    {
                        Console.WriteLine("Enter the number of contact you wanted to Make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person.AddPerson(numContact);
                        Person.PrintPerson();
                    }
                    break;
                case 2:         
                    {
                        Console.WriteLine("Enter the number of contact you wanted to Make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person.AddPerson(numContact);
                        Person.PrintPerson();
                    }
                    break;
                case 3:
                    {   //UC3
                        Console.WriteLine("Enter the Number of Contact You Wanted to make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person addPerson = new Person();
                        Person.AddPerson(numContact);
                        Person.PrintPerson();
                    }
                    break;
                default:
                    Console.WriteLine("Please enter valid option");
                    break;
            }
        }
    }
}