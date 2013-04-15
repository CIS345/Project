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

        //delcare private 2d array. 
        private string [,] FlightArray = new string[20,3];//prototype tracks 20 different flights with flight number, origin, and destination

        //parameterless constructor for flight
        public Flight ()
        {
            
        }

        public Flight(int number, string startLocation, string endLocation)
        {
            FlightNumber = number;
            OriginLocation = startLocation;
            DestinationLocation = endLocation;
            //playing with how to fill array with new flight info, struggling with this.
            FlightArray[0, 0] = Convert.ToString(number);
            startLocation = FlightArray[0, 1];
            endLocation = FlightArray[0, 2];
        }

        //get/set assessor for FlightNumber using the ArrayIndex Parameter 
       /* public string FlightNumber ()
       {

          set //struggling to  somehow get/set an array. I emailed him for help, but...idk how much help he can provide.
            {
                //FlightArray[,0]=value;

            }
        }
            */
           
        

    }

}
