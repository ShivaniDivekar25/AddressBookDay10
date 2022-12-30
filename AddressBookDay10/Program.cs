using System;

namespace AddressBookDay10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Start
            Console.WriteLine("Welcome to Address Book Program!");
            //UC1 - Calling methods
            Person.AddPerson();
            Person.PrintPerson();
        }
    }
}