using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TSAdmin;//added the DLL file in the RobbLooCIS345FinalProject folder

namespace RobbLooCIS345FinalProject
{
    class FlightControl
    {
        //declare instance variables
        private string strFlightNumber;
        private string strOrigin;
        private string strDestination;
        private int intNumOfFlights = 0;

        //delcare private array. 
        private Flight[] FlightArray;

        //parameterless constructor for flight
        public FlightControl()
        {
            //set the reference of this array to the Flight 
            FlightArray = new Flight[20];//prototype tracks 20 different Flight 'Objects' See Flight class to see what its public methods and properties are.
            
            //result stores the number of non null references. If result = 1, then we should have one entry, thus the element of the array needs to be (result - 1)
            intNumOfFlights = FlightArray.Count(s => s != null);
        }

        public void AddFlight()
        {
            Flight tmpFlight;

            //variable that temporarily stores flight input
            string strFlightNumber; //we create this because when we instiantiate a new object, we need a parameter input (look at the Flight.cs's overloaded constructor)
         
            Console.Write("Enter Flight Number:");
            strFlightNumber = Console.ReadLine();

            //initialize temporary flight object
            tmpFlight = new Flight(strFlightNumber);

            Console.Write("Enter Origin: "); //Write Origin in the instantiated object
            tmpFlight.Origin = Console.ReadLine();

            Console.Write("Enter Destination: "); //write the destination to the instantiated object
            tmpFlight.Destination = Console.ReadLine();
            FlightArray[intNumOfFlights] = tmpFlight;

            //this needs code that returns the screen to NeatsMainMenu. I tried to use the other way we did for the Customerstuff we did in 340, but I don't think it will work in console.
        }    
    }
}
