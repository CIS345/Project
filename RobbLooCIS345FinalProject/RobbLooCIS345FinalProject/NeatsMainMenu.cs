using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TSAdmin;//added the DLL file in the RobbLooCIS345FinalProject folder

namespace RobbLooCIS345FinalProject
{
    class NeatsMainMenu
    {
        private Flight flight;
        string[,] FlightArray;
        //declare submenu
        NeatsSubMenu SubMenu; 

//declare a reference point to store the memory location of this page
        private static NeatsMainMenu myParentForm = null;

        static void Main(string[] args)
        {
            //declare and initialize myNeatsMenu by calling the parameterless constructor, NeatsMenu
            NeatsMainMenu myNeatsMenu = new NeatsMainMenu();
            myNeatsMenu.DisplayMenu();
            Console.ReadLine();
        }

//parameterless Constructor created
        NeatsMainMenu()
        {
            //this will set "this" page as a reference point using a set property
            NeatsMainMenu.setParentForm(this);
        }

//create a public static method that can retreive the location of this main screen
        public static NeatsMainMenu getParentForm()
        {
            return myParentForm;
        }

//create a public static method to set the parent form. Accepts a menu paramenter called parent form
        public static void setParentForm(NeatsMainMenu parentform)
        {
            myParentForm = parentform;
        }

//created a method to display info #2 Feature Requirememts
        private void DisplayMenu()
        {   
            //the 3 lines resize the console window size (not really important)
            Console.SetWindowSize(80, 25);
            Console.BufferHeight = 100;
            Console.BufferWidth = 100;


            Console.WriteLine("Northeastern Airlines Transportation System - NEATS Main Menu");
            Console.WriteLine();
            Console.WriteLine("1. Display List of Flights");
            Console.WriteLine("2. Add a New Flight");
            Console.WriteLine("3. Select a Flight");
            Console.WriteLine("4. Search By Passenger");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Select Menu Option: ");
            ReadInput();
        }

//my intent for this method is to split the Displaying with the Read input from the user. This method should direct a user to his destination
        private void ReadInput()
        {
            //store the user input into a variable. ***You can add a validate loop here in case the user uses letters. Recommendations include creating a "UTILITIES CLASS" to make it easier. We can do that l8r*** 
            int intUserInput = Convert.ToInt32(Console.ReadLine());
            switch (intUserInput)
            {
                case 1:
                    DummyFlightInfo();
                    break;
                case 2:
                    //add a new flight
                    //first have initialize an instance of the class (create a new object of the class)
                    ReadFlight();
                    break;
                case 3:
                    //select a flight
                    //moved submenu lines below to case 3 as that's how its implemented in the NEAT.exe example he gave us
                    SubMenu = new NeatsSubMenu();
                    SubMenu.DisplaySubMenu();
                    
                    break;
                case 4:
                    //search by passenger
                    break;
                case 5:
                    //exit the system entirely
                    Environment.Exit(0);
                    break;


            }
        }


        //Method for displaying default flight info initially before array is populated by our data
        //There is probably a better way to do this, just messing around with arrays at this point.
        //pressing any key takes us back to main menu
        public void DummyFlightInfo()
        {
            Console.Clear();
            string[,] FlightArray = { {"700","Seattle","Phoenix"},
                                       {"600","Chicago","New York"},
                                       {"500","Phoenix","San Diego"}, 
                                       {"656","Denver","Austin"}};
            
            Console.WriteLine("\t\t\tCurrent Flights - NEATS system\n\n");
            Console.WriteLine("\t1. #{0}\t\t{1}\t-->\t{2}", FlightArray[0, 0], FlightArray[0, 1], FlightArray[0, 2]);
            Console.WriteLine("\t2. #{0}\t\t{1}\t-->\t{2}", FlightArray[1, 0], FlightArray[1, 1], FlightArray[1, 2]);
            Console.WriteLine("\t3. #{0}\t\t{1}\t-->\t{2}", FlightArray[2, 0], FlightArray[2, 1], FlightArray[2, 2]);
            Console.WriteLine("\t4. #{0}\t\t{1}\t-->\t{2}", FlightArray[3, 0], FlightArray[3, 1], FlightArray[3, 2]);

            Utilities.Back();
            Console.Clear();
            DisplayMenu();          
        }

        //method to read flight info (menu item #2)
        //trying to figure out best way to add flight info to FlightArray.

        public void ReadFlight()
        {
            int number = 0;
            string startLocation = "";
            string endLocation = "";
            Console.Clear();
            Console.WriteLine("\t\tEnter New Flight - NEATS System\n\n");
            Console.Write("Enter flight number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Origin: ");
            startLocation = Console.ReadLine();
            Console.Write("Enter Destination: ");
            endLocation = Console.ReadLine();

            flight = new Flight(number, startLocation, endLocation);
            
            
            Console.Clear();
            DisplayMenu();
        }
        
    }
}
