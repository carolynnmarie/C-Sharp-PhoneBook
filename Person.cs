using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_PhoneBook{
    public class Person{

        public string firstName {get;set;}
        public string lastName {get;set;}
        public string fullName {set{lastName = firstName + " " + lastName;}get{return lastName;}}
        public List<string> phoneNumbers {get;set;}
        public string address {get;set;}
        
        public Person(){
            this.firstName = "";
            this.phoneNumbers = new List<string>();
            this.address = "";
        }

        public Person(string firstName, string lastName, List<string> phoneNumbers,string address){
            this.firstName = firstName;
            this.lastName = lastName;
            this.fullName = firstName + " " + lastName;
            this.phoneNumbers = phoneNumbers;
            this.address = address;
        }

    }
}