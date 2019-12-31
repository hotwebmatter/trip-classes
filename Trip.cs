using System;
using System.Collections.Generic;
using System.Text;

namespace trip_classes
{
    class Trip
    {
        // data members
        private string destination;
        private double milesTraveled,
                       gasolineCostTotal,
                       gasolineGallonsUsed,
                       milesPerGallon,
                       costPerMile;
        // properties
        public string Destination { set; get; }
        public double MilesTraveled { set; get; }
        public double GasolineCostTotal { set; get; }
        public double GasolineGallonsUsed { set; get; }
        public double MilesPerGallon { set; get; }
        public double CostPerMile { set; get; }
        // constructors
        public Trip()
        {
            destination = "New York City";
            milesTraveled = 2789.4;
            gasolineCostTotal = 363.41;
            gasolineGallonsUsed = 111.6;
        }
        public Trip(string dest, double miles, double gasCost, double gasGallons)
        {
            destination = dest;
            milesTraveled = miles;
            gasolineCostTotal = gasCost;
            gasolineGallonsUsed = gasGallons;
        }
        // calculate miles per gallon (void method)
        public void CalculateMilesPerGallon()
        {
            milesPerGallon = milesTraveled / gasolineGallonsUsed;
        }
        // calculate cost per mile (void method)
        public void CalculateCostPerMile()
        {
            costPerMile = gasolineCostTotal / milesTraveled;
        }
        // bonus (not in problem spec): calculate cost per gallon
        public double CalculateCostPerGallon()
        {
            return gasolineCostTotal / gasolineGallonsUsed;
        }
        // override base.ToString() method
        public override string ToString()
        {
            string result = String.Format("****** Trip Mileage Data Table ******\n");
            result += String.Format("* {0, 18}{1, 15} *\n", "Destination:", destination);
            result += String.Format("* {0, 18}{1, 15:N} *\n", "Miles Traveled:", milesTraveled);
            result += String.Format("* {0, 18}{1, 15:C} *\n", "Gas (cost):", gasolineCostTotal);
            result += String.Format("* {0, 18}{1, 15:N} *\n", "Gas (gallons):", gasolineGallonsUsed);
            result += String.Format("* {0, 18}{1, 15:N} *\n", "Miles Per Gallon:", milesPerGallon);
            result += String.Format("* {0, 18}{1, 15:C} *\n", "Cost Per Mile:", costPerMile);
            result += String.Format("* {0, 18}{1, 15:C} *\n", "Cost Per Gallon:", CalculateCostPerGallon());
            result += String.Format("*************************************\n");
            return result;
        }
    }
}
