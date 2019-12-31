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
    }
}
