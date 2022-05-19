using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;
using  static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    public static class CLI
    {
        static void Main(string[] args)
        {
            CleaningSystem cs = new CleaningSystem("Shaun Cleans");

            List<Admin> Admins = new List<Admin>();
            List<Cleaning> Cleaners = new List<Cleaning>();
            List<Customer> Customers = new List<Customer>();
            List<Building> Buildings = new List<Building>();
            List<Maintenance> Maintenance = new List<Maintenance>();
            List<Purchase>  Purchases = new List<Purchase>();
            List<MajorProblem> MajorProblems = new List<MajorProblem>();
            List<MinorProblem> MinorProblems = new List<MinorProblem>();
            List<Booking> Bookings = new List<Booking>();
            List<TimeLog> TimeLogs = new List<TimeLog>();
            List<Service> Services = new List<Service>();

            MainMenu(Admins, Bookings, Cleaners);
            AddStaffMember(Admins, Bookings, Cleaners);

            foreach (Admin admin in Admins)
                Console.WriteLine($"{admin.Fname} {admin.Lname} Username: {admin.Username}");
        }

        static void MainMenu(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList)
        {
            string[] Options =
            {
                "Add a new booking",
                "Find customer information",
                "Update information",
                "View time log",
                "View purchases",
                "Add Staff Member",
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
                case ("Add Staff Member"):
                    AddStaffMember(AdminList, BookingList, CleaningList);
                    break;
            }
        }

        static void AddStaffMember(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList)
        {

            string[] StaffTypes =
            {
                "Admin",
                "Cleaning",
                "Booking"
            };

            string FirstName = Prompt.Input<string>("Staff First Name");
            string LastName = Prompt.Input<string>("Staff Last Name");
            string Username = Prompt.Input<string>("Staff Username");
            string Password = Prompt.Input<string>("Staff Password");

            while (CheckUsername(AdminList, BookingList, CleaningList, Username) == false)
            {
                Username = Prompt.Input<string>("New username");
            }



            string StaffOptions = Prompt.Select("What type of staff member are you adding?", StaffTypes);

            switch (StaffOptions)
            {
                case ("Admin"):
                    Admin NewAdmin = new Admin(FirstName, LastName, Username, Password);
                    AdminList.Add(NewAdmin);
                    break;
                case ("Cleaning"):
                    Cleaning NewCleaning = new Cleaning(FirstName, LastName, Username, Password);
                    CleaningList.Add(NewCleaning);
                    break;
                case ("Booking"):
                    Booking NewBooking = new Booking(FirstName, LastName, Username, Password);
                    BookingList.Add(NewBooking);
                    break;
            }
        }

        static bool CheckUsername(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList, string Username)
        {
            foreach (Admin admin in AdminList)
            {
                if (admin.Username == Username)
                {
                    Console.WriteLine("Invalid username. PLease enter a new one");
                    return false;
                }
            }

            foreach (Cleaning cleaner in CleaningList)
            {
                if (cleaner.Username == Username)
                {
                    Console.WriteLine("Invalid username. PLease enter a new one");
                    return false;
                }
            }

            foreach (Booking booking in BookingList)
            {
                if (booking.Username == Username)
                {
                    Console.WriteLine("Invalid username. PLease enter a new one");
                    return false;
                }
            }

            return true;
        }

        static void AddNewPurchase(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList)
        {
            string CleanerUsername = Prompt.Input<string>("What is the cleaners username");
            bool found = false;

            foreach (Cleaning Cleaner in CleaningList)
            {
                if (Cleaner.Username == CleanerUsername)
                {
                    Cleaning TargetCleaner = Cleaner;
                    Console.WriteLine(TargetCleaner.Fname);
                    found = true;

                    string Description = Prompt.Input<string>("Purchase Description");
                    double Cost = Prompt.Input<double>("Purchase cost");

                    Purchase NewPurchase = new Purchase(Description, Cost, TargetCleaner);
                }
            }

            if(found == false)
            {
                Console.WriteLine($"{CleanerUsername} cleaner was not found");
            }
        }

        static void AddSerService()
        {

        }
    }
}