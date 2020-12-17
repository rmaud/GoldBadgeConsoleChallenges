﻿using EmployeeBadge_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeBadge_Console
{
    class EmployeeBadgeUI
    {
        private EmployeeBadgeRepository _employeeBadgeRepo = new EmployeeBadgeRepository();
        public void Run()
        {

        }

        //Menu
        private void MainMenu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display Options:
                Console.WriteLine("Hello Security Admin, what would you like to do?\n" +
                    "1. Add a badge\n" +
                    "2. Edit a badge\n" +
                    "3. List all badges\n");
                //Get User Input
                string userInput = Console.ReadLine();
                //Evaluate user input
                switch (userInput)
                {
                    case "1":
                        //Add badge
                        break;
                    case "2":
                        //Edit a badge
                        break;
                    case "3":
                        //List all badges
                        break;
                    default:
                        Console.WriteLine("Please enter a valid option to continue...");
                        break;
                }
                Console.WriteLine("Press any key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //Create Method
        private void AddBadge()
        {
            Console.Clear();
            EmployeeBadge newBadge = new EmployeeBadge();
            //Badge ID
            Console.WriteLine("What is the number on the badge: (ex. 1234)");
            string badgeAsString = Console.ReadLine();
            newBadge.BadgeID = int.Parse(badgeAsString);
            //Door ID
            Console.WriteLine("List a door that it needs access to:");
            newBadge.DoorID = Console.ReadLine();
            Console.WriteLine("Any other doors? (y/n)");
            string userInput = Console.ReadLine();
            if(userInput == "y")
            {
                Console.WriteLine("List a door that it needs access to:");
                newBadge.DoorID = Console.ReadLine();
            }
            else
            {
                Console.Clear();
                MainMenu();
            }
        }

        //EDIT METHOD(S)

        //READ ALL METHOD
    }
}
