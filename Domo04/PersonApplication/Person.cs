using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public Person()
        {
        }
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }
        protected void PersonMethod()
        {
            Console.WriteLine("This method belongs to Person!");
        }
        public override string ToString()
        {
            return Firstname + " " + Lastname + " " + Adress + " " + Age + " " + PhoneNumber + " ";


        }





    }
}
