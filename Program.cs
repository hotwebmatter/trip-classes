using System;
using static System.Console;

namespace trip_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Trip aTrip = new Trip();
            aTrip.CalculateMilesPerGallon();
            aTrip.CalculateCostPerMile();
            Trip bTrip = new Trip("Los Angeles", 2789.4, 363.41, 111.6);
            bTrip.CalculateMilesPerGallon();
            bTrip.CalculateCostPerMile();
            WriteLine(aTrip.ToString());
            WriteLine(bTrip.ToString());
        }
    }
}
