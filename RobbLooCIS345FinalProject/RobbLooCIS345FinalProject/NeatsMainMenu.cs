using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TSAdmin;//added the DLL file in the RobbLooCIS345FinalProject folder

namespace RobbLooCIS345FinalProject
{
    class NeatsMainMenu
    {
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
            Console.SetWindowSize(100, 40);
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
                    //list flights
                    break;
                case 2:
                    //add a new flight
                    //first have initialize an instance of the class (create a new object of the class)
                    SubMenu = new NeatsSubMenu();
                    SubMenu.DisplaySubMenu();                    
                    break;
                case 3:
                    //select a flight
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
        
    }
}
