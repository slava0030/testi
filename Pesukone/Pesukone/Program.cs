using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pesukone
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one instance of car class
            Car car = new Car();
            car.PrintData();
            car.Model = "Datsun 100A";
            car.Color = "Green";
            car.Engine = 1.0;
            car.Speed = 10;
            car.FuzzyDices = true;
            car.DoorCount = 2;
            car.SomeProperty = 100;
            car.PrintData();
            car.Accelerate();
            Console.WriteLine("Speed= " + car.Speed);
            car.Brake(2);
            Console.WriteLine("Speed = " + car.Speed);

           


        }
    }
}
