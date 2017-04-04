using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nkandla
{
    public class Person 
    {
        private string name;
        private int Age;
        private char Gender;
        private Type type;
        private Party party;
        public Person(string _Name, int _Age, char _Gender, Type _type, Party _Party)
        {
            this.name = _Name;
            this.Age = _Age;
            this.Gender = _Gender;
            this.type = _type;
            this.Party = _Party;
        }

        public Party Party
        {
            get { return this.party; }
            set { this.party = value; }
        }
        public Type Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public string Name
        {
            get { return this.name; }
        }


        public override string ToString()
        {
            return "Person Info:\nName:" + this.name + "\nAge:" + this.Age.ToString() + "\nGender:" + this.Gender + "\nType:" + this.type + "\nParty:" + this.party + "\n";
        }
    }
}
