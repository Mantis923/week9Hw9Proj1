using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week9Hw9Proj1
{
    class Odometer
    {
        private double oldMiles, totalMilage, miles, TmilesDriven,gallons;

        public Odometer(double miles, double average)
        {
            oldMiles = miles;
            TmilesDriven = miles;
            totalMilage = average;
        }
       

        

        public double TotalmilesDriven { get => miles; set => miles = value; }
        public double OldMiles { get => miles; set => miles = value; }
        public double TotalMilage { get => totalMilage; set => totalMilage = value; }

      


        public double Addmiles(double newMiles)
        {

           TotalmilesDriven = 0;
           TotalmilesDriven = newMiles;
            return Average(TotalmilesDriven);
        }
        public double Reset()
        {
            TotalmilesDriven = 0;
            return Addmiles(TotalmilesDriven);
        }


        public double Average(double newtrip)
        {

            gallons = (newtrip/TotalMilage);
            return gallons;
        }
        public override String ToString()
        {

            return "NUMBER OF GALLONS USED ON " + Math.Round(TotalmilesDriven, 1)
                + " miles trip = " + Math.Round(gallons, 1)
                    + "\nTOTAL MILES AFTER TRIP: " + (Math.Round(oldMiles, 1) + Math.Round(TotalmilesDriven, 1));
        }
     }
}