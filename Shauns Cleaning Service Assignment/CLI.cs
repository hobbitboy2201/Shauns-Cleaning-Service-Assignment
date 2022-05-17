using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;

namespace Shauns_Cleaning_Service_Assignment
{
    public static class CLI
    {
        static void Main(string[] args)
        {
            CleaningSystem cs = new CleaningSystem("Shaun Cleans");

            MainMenu();
        }

        static void MainMenu()
        {
            string[] Options =
            {
                "Add a new booking",
                "Find customer information",
                "Update information",
                "View time log",
                "View purchases",
                "Quit"
            };

            string MenuOptions = Prompt.Select("Welcome to Shauns Cleaning Services!", Options);

            switch (MenuOptions)
            {
                case ("Add a new booking"):
                    Console.WriteLine("New booking");
                    break;
                case ("Find customer information"):
                    Console.WriteLine("Find customer information");
                    break;
                case ("Update information"):
                    Console.WriteLine("Update information");
                    break;
                case ("View time log"):
                    Console.WriteLine("Time log");
                    break;
                case ("View purchases"):
                    Console.WriteLine("View Purchases");
                    break;
                case ("Quit"):
                    Console.WriteLine("Quit");
                    break;
            }
        }

        static void AddBooking()
        {
            string Fname = Prompt.Input<string>("What is the staff members first name");
            string Lname = Prompt.Input<string>("What is the staff members last name");

            string Username = Prompt.Input<string>("What is the staff members username");
            string Password = Prompt.Input<string>("What is the staff members password");

            Booking NewBooking = new Booking(Fname, Lname, Username, Password);
        }
    }
}
