using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TSAdmin;//added the DLL file in the RobbLooCIS345FinalProject folder

namespace RobbLooCIS345FinalProject
{
    class Flight
    {
        public int FlightNumber { get; set; }
        public string OriginLocation { get; set; }
        public string DestinationLocation { get; set; }
        private static int intFlightCount = 0;

        //parameterless constructor for flight
        public Flight ()
        {
            intFlightCount++;
        }

        //overloaded constructor for flight
        public Flight(int number, string startLocation, string endLocation)
        {
            FlightNumber = number;
            OriginLocation = startLocation;
            DestinationLocation = endLocation;
            intFlightCount++;
        }

        //property to return flight counter
        public static int FlightCount
        {
            get { return intFlightCount; }
        }
    }
}
