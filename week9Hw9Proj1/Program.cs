using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Define a class called Odometer that will be used to track
/// fuel usage and miles per gallon. Create two constructors, 1 constructor should be the no-argument constructor the other 
/// will set the two instance variables.The class should have instance variables for mileage 
/// driven and fuel used.Include a reset method that sets the mileage 
/// drive and the fuel used to zero.Include an add method which takes two parameters that add 
/// to the fuel consumed and the miles driven.
/// </summary>

namespace week9Hw9Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            Odometer o1 = new Odometer(53.7, 32.1);
            Odometer o2 = new Odometer(42.9, 15.4);


            o1.Addmiles(61.7);
            o2.Addmiles(444.45);

            Console.WriteLine(o1);
            Console.WriteLine(o2);
            Console.ReadLine();

            //Console.ReadLine();
            //Odometer trip1 = new Odometer(53.7,32.1,0);
            //trip1.add(200, 34);
            //trip1.getMiles();
            //Console.WriteLine("fuel used for trip 1 is : " + Math.Round(trip1.MPG(),2));
            //Console.WriteLine("Miles driven for trip 1: " + trip1.getMiles());
            //Odometer trip2 = new Odometer();
            //trip2.add(200, 10);
            //Console.WriteLine("fuel used for trip 2 is : " + Math.Round(trip2.MPG(),2));
            //trip1.reset();
            //Console.WriteLine("Fuel used fpr trip 1 is:" + Math.Round(trip1.MPG(), 2));//trip1.ToString()

            //trip2.add(150, 0);
            //Console.WriteLine("Fuel used for trip 2 is: " + Math.Round(trip2.MPG(), 2));//trip2.MPG(),2)
            //Console.ReadLine();
            //trip1.addMiles(25.2,0);

            //Console.WriteLine(trip1);

        }
        
    }
}
