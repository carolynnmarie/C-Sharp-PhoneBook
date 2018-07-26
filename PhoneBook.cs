using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_PhoneBook{


    public class PhoneBook{

        public SortedDictionary<string, List<string>> book {get; set;}

        public PhoneBook()=> book = new SortedDictionary<string, List<string>>();

        public PhoneBook(SortedDictionary<string, List<string>> book1) => book = book1;

        public void addEntry(string name, List<String> numbers){
            if(!book.ContainsKey(name)) book.Add(name,numbers);
        }

        public void addNumber(string name, string phoneNumber){
            if(book.ContainsKey(name)){
                book[name].Add(phoneNumber);
            }
        }

        public void removeNumberFromEntry(string name, string number){
            foreach(var entry in book){
                if(entry.Value.Contains(number)) entry.Value.Remove(number);
            }
        }

        public void removeEntry(string name){
            if(book.ContainsKey(name)) book.Remove(name);
        }

        public List<string> lookup(string name){
            List<string> numbers = new List<string>();
            foreach(var entry in book){
                if(entry.Key.Equals(name)) {
                    numbers = entry.Value;
                }
            }
            return numbers;
        }

        public string reverseLookup(string number){
            string name = "";
            foreach(var entry in book){
                if(entry.Value.Contains(number)) name = entry.Key;
            }
            return name;
        }

        public string printEntries(){
            StringBuilder print = new StringBuilder();
            foreach(var entry in book){
                print.Append(entry.Key.ToString())
                .Append(" ")
                .Append(String.Join(" ",entry.Value))
                .Append("\n");
            }
            return print.ToString();
        }

    }
}