using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDictionary.Entities
{
    internal class Person
    {
        public string name { get; set; }

        public Person() { }

        public Person(string name)
        {
            this.name = name;
        }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Person))
            {
                return false;
            }
            Person name1 = (Person)obj;
            return name.Equals(name1.name);
        }
    }
}
