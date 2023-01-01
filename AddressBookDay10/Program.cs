﻿using System;

namespace AddressBookDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start
            Console.WriteLine("Welcome to Address Book Program!");
            Console.WriteLine("Entern\n1:Ability to create Contacts in AddressBook\n2:Ability to add new coontact to AddressBook\n3:Edit contact in AddressBook\n4:Remove contact from AddressBook");
            int option = Convert.ToInt32(Console.ReadLine());       //Taking user input
            //Calling methods using Switch case for UC1,UC2, UC3 and UC4 
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
                        Console.WriteLine("Enter the first name of contact you wanted to Make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person.AddPerson(numContact);
                        Person.PrintPerson();
                    }
                    break;
                case 3:
                    {
                        Console.WriteLine("Enter the first name of Contact you wanted to Edit");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person addPerson = new Person();
                        Person.AddPerson(numContact);
                        Person.PrintPerson();
                    }
                    break;
                case 4:
                    {
                        Console.WriteLine("Enter the number of Contact you wanted to make");
                        int numContact = Convert.ToInt32(Console.ReadLine());
                        Person.AddPerson(numContact);
                        Person.PrintPerson();
                        Console.WriteLine("Enter the first name of contact you wanted to remove");
                        string name = Convert.ToString(Console.ReadLine());
                        Person deleteContact = new Person();
                        deleteContact.deleteContact(name);
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
