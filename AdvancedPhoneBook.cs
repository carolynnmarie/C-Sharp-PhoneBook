using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_PhoneBook{
    public class AdvancedPhoneBook{
        public List<Person> personList {get;set;}

        public AdvancedPhoneBook(){
            this.personList = new List<Person>();
        }

        public void sortByLastName(){
            personList.Sort((p1,p2)=>p1.lastName.CompareTo(p2.lastName));
        }

        public void addPerson(Person person){
            int x = 0;
            foreach(Person p in personList){
                if(person.fullName.Equals(p.fullName)){
                    x++;
                }
            }
            if(x == 0){
                personList.Add(person);
                sortByLastName();
            }
        }
        public void deleteEntry(Person person){
            List<string> nameList = new List<string>();
            foreach(Person p in personList){
                nameList.Add(p.fullName);
            }
            if(nameList.Contains(person.fullName)){
                personList.Remove(person);
            }
        }
        public void addNumberToEntry(Person person, string phoneNumber){
            foreach(Person p in personList){
                if(person.fullName.Equals(p.fullName)){
                    person.phoneNumbers.Add(phoneNumber);
                }
            }
        }
        public void removeNumberFromEntry(Person person, string phoneNumber){
            int x = 0;
            for(int i = 0; i<personList.Count; i++){
                foreach(string pNumber in personList[i].phoneNumbers){
                    if(pNumber.Equals(phoneNumber)){
                        x = i;
                    }
                }
            }
            personList[x].phoneNumbers.Remove(phoneNumber);
        }
        public void changeAddress(Person person, string address1){
            foreach(Person p in personList){
                if(p.fullName.Equals(person.fullName)){
                    p.address = address1;
                }
            }
        }
        public string lookupPhoneNumbersByName(string name){
            Person p1 = new Person();
            foreach(Person p in personList){
                if(p.fullName.Equals(name)){
                    p1 = p;
                }
            }
            return String.Join(", ",p1.phoneNumbers);
        }
        public string reverseLookup(string phoneNumber){
            Person p1 = new Person();
            foreach(Person p in personList){
                if(p.phoneNumbers.Contains(phoneNumber)){
                    p1 = p;
                }
            }
            return p1.fullName;
        }

        public List<Person> getAllResidentsAtAddress(string address){
            List<Person> residents = new List<Person>();
            foreach(Person p in personList){
                if(p.address.Equals(address)){
                    residents.Add(p);
                }
            }
            return residents;
        }

        public string getAllNames(){
            List<string> names = new List<string>();
            foreach(Person p in personList){
                names.Add(p.fullName);
            }
            return String.Join(", ",names);
        }

        public string getAddressByName(Person person){
            string x = "";
            foreach(Person p in personList){
                if(p.fullName.Equals(person.fullName)){
                    x = p.address;
                }
            }
            return x;
        }

    }
}