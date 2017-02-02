using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heater
{
    class Heater
    {
         {
        //properties aka ominaisuudet
        public string Model { get; set; }
        public string Color { get; set; }
        public double Temperature { get; set; }
        public int Moisture { get; set; }
        public bool SwitchedOn { get; set; }


        //constructor... default

        public Heater()
        {


        }
        //constructor
        public Heater(string model)
        {
            Model = model;
        }
        //method to give change temperature
        public void Degrees(int value)
        {
            Temperature += value;
        }
        //method to change moisure
        public void Persents(int value)
        {
            Moisture -= value;
        }
        //method to display heater's properties
        public void PrintData()
        {

            Console.WriteLine("- model:" + Model);
            Console.WriteLine("- color:" + Color);
            Console.WriteLine("- Temperature, C : " + Temperature);
            Console.WriteLine("- Moisture, % : " + Moisture);
            Console.WriteLine("- Is swithed on : " + SwitchedOn);

        }

        //destructor
        ~Heater()
        {
            Console.WriteLine("Heater object is destroyed! ");
        }
    }
}
    }
}
