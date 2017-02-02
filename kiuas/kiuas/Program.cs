using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeaterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of heater class
            Heater heater = new Heater();
            heater.PrintData();
            heater.Model = "superHeater";
            heater.Color = "Grey";
            heater.Temperature = 99.9;
            heater.Moisture = 40;
            heater.SwitchedOn = true;
            heater.PrintData();
            
                      
        }
    }
}