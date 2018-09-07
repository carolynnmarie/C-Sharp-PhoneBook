using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_PhoneBook{
    public class AdvancedPhoneBook{
        public List<Person> personList {get;set;}

        public AdvancedPhoneBook(){
            this.personList = new List<Person>();
        }
        public AdvancedPhoneBook(List<Person> personList){
            this.personList = personList;
        }

        public void sortByLastName(){
            personList.Sort((p1,p2)=>p1.lastName.CompareTo(p2.lastName));
        }

        public void addEntry(Person person){
            bool x = true;
            foreach(Person p in personList){
                if(person.fullName.Equals(p.fullName)){
                    x = false;
                }
            }
            if(x){
                personList.Add(person);
                sortByLastName();
            }
        }
        public void deleteEntry(Person person){
            personList.ForEach(p => {
                if(p.fullName.Equals(person.fullName)){
                    personList.Remove(p);
                }
            });
        }
        public void addNumberToEntry(Person person, string phoneNumber){
            foreach(Person p in personList){
                if(person.fullName.Equals(p.fullName)){
                    p.phoneNumbers.Add(phoneNumber);
                }
            }
        }
        public void removeNumberFromEntry(Person person, string phoneNumber){
            personList.ForEach(p => {
                if(person.fullName.Equals(p.fullName)){
                    if(p.phoneNumbers.Contains(phoneNumber)){
                        p.phoneNumbers.Remove(phoneNumber);
                    }
                }
            });
        }
        public void changeAddress(Person person, string address1){
            foreach(Person p in personList){
                if(p.fullName.Equals(person.fullName)){
                    p.address = address1;
                }
            }
        }
        public string lookupPhoneNumbersByName(string name){
            string x = "";
            personList.ForEach(p => {
                if(p.fullName == name){
                    x = String.Join(", ",p.phoneNumbers);
                }
            });
            return x;
        }
        public string reverseLookup(string phoneNumber){
            string p1 = "";
            foreach(Person p in personList){
                if(p.phoneNumbers.Contains(phoneNumber)){
                    p1 = p.fullName;
                }
            }
            return p1;
        }

        public string getAllResidentsAtAddress(string address1){
            List<Person> residents = new List<Person>();
            personList.ForEach(p => {
                if(p.address == address1){
                    residents.Add(p);
                }
            });
            return String.Join(",",residents);
        }

        public string getAllNames(){
            List<string> names = new List<string>();
            personList.ForEach(p => names.Add(p.fullName));
            return String.Join(", ",names);
        }

        public string getAddressByName(String name){
            string x = "";
            personList.ForEach(p =>{
                if(p.fullName.Equals(name)){
                    x = p.address;
                }
            });
            return x;
        }

        public string printContacts(){
            string print = "";
            personList.ForEach(p => print+=p.toString());
            return print;
        }

    }
}