using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobbLooCIS345FinalProject
{
    //this class will hopefully access the flight.cs class and CONTAIN THE ARRAY OF FLIGHT CLASSES.
    class ConstructFlight
    {
        private const int intNumOfFlights = 20; //20 flights
        private Flight[] FlightArray = new Flight[intNumOfFlights];
        private Flight tmpFlight;

        //parameterless constructor
        public ConstructFlight()
        {      
            //fill in default test data. This would obviously be taken out after the prototype phase
            FillFlightData();
        }

        //public ConstructFlight()
        

        //fill in default test data. This would obviously be taken out after the prototype phase
        private void FillFlightData()
        {
           
            //declare and instantiate Flights

            //flight 1
            tmpFlight = new Flight();
            tmpFlight.FlightNumber = 700;
            tmpFlight.OriginLocation = "Seattle";
            tmpFlight.DestinationLocation = "Phoenix";
            FlightArray[Flight.FlightCount - 1] = tmpFlight;

            tmpFlight = new Flight();
            tmpFlight.FlightNumber = 600;
            tmpFlight.OriginLocation = "Chicago";
            tmpFlight.DestinationLocation = "New York";
            FlightArray[Flight.FlightCount - 1] = tmpFlight;

            tmpFlight = new Flight();
            tmpFlight.FlightNumber = 500;
            tmpFlight.OriginLocation = "Phoenix";
            tmpFlight.DestinationLocation = "San Diego";
            FlightArray[Flight.FlightCount - 1] = tmpFlight;

            tmpFlight = new Flight();
            tmpFlight.FlightNumber = 656;
            tmpFlight.OriginLocation = "Denver";
            tmpFlight.DestinationLocation = "Austin";
            FlightArray[Flight.FlightCount -1] = tmpFlight;
        }
        public void ReadFlightData()
        {
            Console.Clear();
            string strDisplayListOfFlightInfo;
            for (int i = 0; i < Flight.FlightCount; i++)
            {
                strDisplayListOfFlightInfo = FlightArray[i].FlightNumber +" "+ FlightArray[i].OriginLocation + " ---> "+ FlightArray[i].DestinationLocation;
                Console.WriteLine(strDisplayListOfFlightInfo);
            }
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
            NeatsMainMenu.getParentForm();        
        }
    }
}
