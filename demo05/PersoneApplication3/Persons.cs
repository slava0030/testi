using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersoneApplication3
{
    class Persons
    {
        //persons collecion stores person objects
        private List<Person> persons;

        public Persons()
        {
            persons = new List<Person>();
        }

        /// <summary>
        /// add person to collection
        /// </summary>
        /// <param name="person">person to add</param>

        public void AddPerson(Person person)
        {
            persons.Add(person);
        }

        public Person Getperson(int index)
        {
            if (index < persons.Count) return persons.ElementAt(index);
            else return null;
        }

        public Person FindPerson(string SosialSecurityNumber)
        {
            foreach(Person person in persons)
            {    //compare to string
                if (SosialSecurityNumber.Equals(person.SosialSecurityNumber))
                {
                    return person;
                }
            }
            return null; //person with searched socials was not found in collection

        }
        public void PrintData()
        {
            foreach(Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }

    }
}
