﻿using System;
using System.Collections.Generic;

namespace C_Sharp_PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
//            SimplePhoneBook phonebook = new SimplePhoneBook();

            AdvancedPhoneBook book = new AdvancedPhoneBook();
            List<string> numbers1 = new List<string>();
            numbers1.Add("(302)555-2229");
            numbers1.Add("(610)555-3450");
            List<string> numbers2 = new List<string>();
            numbers2.Add("(444)555-6666");
            numbers2.Add("(555)555-5555");
            Person joe = new Person("Joe","Smith",numbers1,"123 Spring Lane");
            Person carolynn = new Person ("Carolynn","Vansant",numbers2,"212 S Willow St");
            book.addEntry(joe);
            book.addEntry(carolynn);
            book.removeNumberFromEntry(carolynn,"(555)555-5555");
            Console.WriteLine(book.lookupPhoneNumbersByName("Carolynn Vansant"));
 //           phonebook.addEntry("Joe", numbers2);
            // phonebook.addEntry("Carolynn", numbers1);
            // string stringNumbers = String.Join(" ",phonebook.lookup("Carolynn"));
            // string name = phonebook.reverseLookup("(610)555-3450");
            // phonebook.removeEntry("Carolynn");
 //           phonebook.removeNumberFromEntry("Joe","(555)555-5555");

 //           Console.WriteLine(phonebook.printEntries());
        }
    }
}
