using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersoneApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // create Persons ( collection )
            Persons myFriends = new Persons();

            // create a few Person objects
            Person person1 = new Person { Firstname = "Ura", Lastname = "Seleznev", SosialSecurityNumber = "19440509-1488" };
            Person person2 = new Person { Firstname = "Lah", Lastname = "Ipanij", SosialSecurityNumber = "22222222-2222" };
            Person person3 = new Person { Firstname = "Ma", Lastname = "Lol", SosialSecurityNumber = "33333333-3333" };
            // add Person objects to Persons (myFriends)
            myFriends.AddPerson(person1);
            myFriends.AddPerson(person2);
            myFriends.AddPerson(person3);

       


        // get one person
        Person person4 = myFriends.GetPerson(0);
        if (person4 != null)
            {
            Console.WriteLine(person4.ToString());
            } else
            {
                Console.WriteLine("There is no person at that position!");
    }
// print collection
myFriends.PrintData();
    //find person
    string SocialSecurityNumber = "222222-2222";
    Console.WriteLine("Find person with ssn :" + SocialSecurityNumber);
    Person person5 = myFriends.FindPerson(SocialSecurityNumber);
    if (person5 != null)
    {
    Console.WriteLine(person5.ToString());
    } else 
    {
    Console.WriteLine("Can't find person with that ssn");
    }
}
    }