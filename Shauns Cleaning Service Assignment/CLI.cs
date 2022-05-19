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

            MainMenu(Admins, Bookings, Cleaners, Purchases, Buildings, Services);

            foreach (Admin admin in Admins)
                Console.WriteLine($"{admin.Fname} {admin.Lname} Username: {admin.Username}");
        }

        static void MainMenu(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList, List<Purchase> PurchaseList, List<Building> BuildingList, List<Service> ServiceList)
        {
            string[] Options =
            {
                "Update information",
                "View time log",
                "Add New Purchase",
                "View Purchases",
                "View Buildings",
                "Add Staff Member",
                "Add Service",
                "Add Building",
                "Quit"
            };

            string MenuOptions = Prompt.Select("Welcome to Shauns Cleaning Services!", Options);

            switch (MenuOptions)
            {
                case ("Update information"):
                    Console.WriteLine("Update information");
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList);
                    break;
                case ("View time log"):
                    Console.WriteLine("Time log");
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList);
                    break;
                case ("View Purchases"):
                    Console.WriteLine("View Purchases");
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList);
                    break;
                case ("Add New Purchase"):
                    AddNewPurchase(AdminList, BookingList, CleaningList, PurchaseList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList);
                    break;
                case ("Add Staff Member"):
                    AddStaffMember(AdminList, BookingList, CleaningList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList);
                    break;
                case ("Add Building"):
                    AddBuilding(BuildingList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList);
                    break;
                case ("View Buildings"):
                    ViewBuildings(BuildingList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList);
                    break;
                case ("Add Service"):
                    AddService(BuildingList, ServiceList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList);
                    break;
                case ("Quit"):
                    Console.WriteLine("Quitting");
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

        static void AddNewPurchase(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList, List<Purchase> PurchaseList)
        {
            string CleanerUsername = Prompt.Input<string>("What is the cleaners username");
            bool found = false;

            foreach (Cleaning Cleaner in CleaningList)
            {
                if (Cleaner.Username == CleanerUsername)
                {
                    Cleaning TargetCleaner = Cleaner;
                    found = true;

                    string Description = Prompt.Input<string>("Purchase Description");
                    double Cost = Prompt.Input<double>("Purchase cost");

                    Purchase NewPurchase = new Purchase(Description, Cost, TargetCleaner);

                    PurchaseList.Add(NewPurchase);
                }
            }

            if(found == false)
            {
                Console.WriteLine($"{CleanerUsername} cleaner was not found");
            }
        }

        static void AddBuilding(List<Building> BuildingList)
        {

            Nature[] Types = { Nature.DOMESTIC, Nature.COMMERCIAL};

            string Fname = Prompt.Input<string>("Customer First Name");
            string Lname = Prompt.Input<string>("Customer Last Name");

            string Address = Prompt.Input<string>("Building Address");

            Nature Type = Prompt.Select("Type of Building", Types);
            Customer customer = new Customer(Fname, Lname);

            Building Newuilding = new Building(Address, Type, customer);

            BuildingList.Add(Newuilding);
        }

        static void AddService(List<Building> BuildingList, List<Service> ServiceList)
        {
            string ServiceName = Prompt.Input<string>("Service name");

            string Address = Prompt.Input<string>("Service Building Address");
            bool found = false;
            Building Building;

            foreach (Building Building1 in BuildingList)
            {
                if (Building1.Address == Address)
                {
                    Building = Building1;
                    found = true;

                    string Complete = Prompt.Select("Is the service complete?", new[] { "Yes", "No"});

                    bool BComplete;

                    if (Complete == "Yes")
                    {
                        BComplete = true;
                    }
                    else
                    {
                        BComplete = false;
                    }

                    Customer customer = new Customer(Building.CurrentCustomer.Fname, Building.CurrentCustomer.Lname);

                    Service NewService = new Service(ServiceName, BComplete, customer, Building);

                    Building.Services.Add(NewService);
                    ServiceList.Add(NewService);
                }
            }
            if (found == false)
            {
                Console.WriteLine("Invalid Address Given");
            }
        }

        static void ViewBuildings(List<Building> Buildings)
        {
            foreach (Building building in Buildings)
            {
                Console.WriteLine($"Address: {building.Address}");
                Console.WriteLine($"Type: {building.Type}");
                Console.WriteLine($"Current Tenant: {building.CurrentCustomer.Fname} {building.CurrentCustomer.Lname}");
                foreach (Service service in building.Services)
                {
                    Console.WriteLine(service);
                }
            }
        }

        static void ViewTimeLog()
        {

        }

        static void UpdateInformation()
        {

        }
        static void Quit()
        {

        }
    }
}