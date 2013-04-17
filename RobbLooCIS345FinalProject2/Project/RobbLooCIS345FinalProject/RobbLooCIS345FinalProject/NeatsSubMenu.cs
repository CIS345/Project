using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TSAdmin;//added the DLL file in the RobbLooCIS345FinalProject folder

namespace RobbLooCIS345FinalProject
{
    class NeatsSubMenu
    {
        public NeatsSubMenu()
        { 
        }
        public void DisplaySubMenu()
        {
            Console.WriteLine("Northeastern Airlines Transportation System - NEATS Main Menu");
            Console.WriteLine();
            Console.WriteLine("1. Display flight information for slected flight");
            Console.WriteLine("2. Add a flight");
            Console.WriteLine("3. Edit flight information");
            Console.WriteLine("4. Add new passengers");
            Console.WriteLine("5. Submit the passenger manifest to TSA and update the manifest based on the returned list of flagged passengers");
            Console.WriteLine("6. Exit the sub menu");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Select Menu Option: ");
        }

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
                    //first have to declare and initialize an instance of the class (create a new object of the class)
                    NeatsSubMenu SubMenu = new NeatsSubMenu();
                    SubMenu.DisplaySubMenu();
                    break;
                case 3:
                    //select a flight
                    break;
                case 4:
                    //search by passenger
                    break;
                case 5:
                    //Submit the passenger manifest to TSA and update the manifest based on the returned list of flagged passengers
                    break;
                case 6:
                    //exit the system entirely
                    NeatsMainMenu.getParentForm();
    
                 //Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
    }
}
