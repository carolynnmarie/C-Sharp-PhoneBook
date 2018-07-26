using System;
using System.Collections.Generic;

namespace C_Sharp_PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();
            List<string> numbers1 = new List<string>();
            numbers1.Add("(302)555-2229");
            numbers1.Add("(610)555-3450");
            List<string> numbers2 = new List<string>();
            numbers2.Add("(444)555-6666");
            phonebook.addEntry("Joe", numbers2);
            phonebook.addEntry("Carolynn", numbers1);
            string stringNumbers = String.Join(" ",phonebook.lookup("Carolynn"));
            string name = phonebook.reverseLookup("(610)555-3450");
            phonebook.removeEntry("Carolynn");

            Console.WriteLine(phonebook.printEntries());
        }
    }
}
