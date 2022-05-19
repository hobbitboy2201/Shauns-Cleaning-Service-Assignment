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

            Customer SomeCustomer = new Customer("Ben", "Pople");

            Building building1 = new Building("Oxford", Nature.DOMESTIC, SomeCustomer);

            Service Service1 = new Service("Test1", false, SomeCustomer, building1);
            Service Service2 = new Service("Test69", true, SomeCustomer, building1);
            Cleaning Cleaner1 = new Cleaning("Jim", "Baggings", "Jim123", "Jim123");

            building1.Services.Add(Service1);
            building1.Services.Add(Service2);

            Cleaners.Add(Cleaner1);
            Buildings.Add(building1);
            Customers.Add(SomeCustomer);

            MainMenu(Admins, Bookings, Cleaners, Purchases, Buildings, Services, Customers, TimeLogs);
        }

        static void MainMenu(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList, List<Purchase> PurchaseList, List<Building> BuildingList, List<Service> ServiceList, List<Customer> CustomerList, List<TimeLog> TimeLogList)
        {
            string[] Options =
            {
                "Update Information",
                "Add Time Log",
                "View Time Log",
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
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("Add Time Log"):
                    AddTimeLog(CleaningList, TimeLogList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("View time log"):
                    ViewTimeLog(TimeLogList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("View Purchases"):
                    Console.WriteLine("View Purchases");
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("Add New Purchase"):
                    AddNewPurchase(AdminList, BookingList, CleaningList, PurchaseList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("Add Staff Member"):
                    AddStaffMember(AdminList, BookingList, CleaningList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("Add Building"):
                    AddBuilding(BuildingList, CustomerList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("View Buildings"):
                    ViewBuildings(BuildingList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("Add Service"):
                    AddService(BuildingList, ServiceList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
                    break;
                case ("Update Information"):
                    UpdateInformation(CustomerList, BuildingList, AdminList, CleaningList);
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList);
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

        static void AddBuilding(List<Building> BuildingList, List<Customer> CustomerList)
        {

            Nature[] Types = { Nature.DOMESTIC, Nature.COMMERCIAL};

            string Fname = Prompt.Input<string>("Customer First Name");
            string Lname = Prompt.Input<string>("Customer Last Name");

            string Address = Prompt.Input<string>("Building Address");

            Nature Type = Prompt.Select("Type of Building", Types);
            Customer customer = new Customer(Fname, Lname);

            Building Newuilding = new Building(Address, Type, customer);

            CustomerList.Add(customer);
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
                    Console.WriteLine();
                }
            }
        }



        static void UpdateInformation(List<Customer> CustomerList, List<Building> BuildingList, List<Admin> AdminList, List<Cleaning> CleanerList)
        {
            string[] Information =
            {
                "Customer",
                "Building",
                "Admins",
                "Cleaners"
            };

            string UpdateChoice = Prompt.Select("What infomration would you like to update", Information);

            switch (UpdateChoice)
            {
                case ("Customer"):
                    UpdateCustomer(CustomerList);
                    break;
                case ("Building"):
                    UpdateBuilding(BuildingList, CustomerList);
                    break;
                case ("Admins"):
                    UpdateAdmins(AdminList);
                    break;
                case ("Cleaners"):
                    UpdateCleaning(CleanerList);
                    break;
            }

        }

        static void UpdateAdmins(List<Admin> AdminList)
        {
            List<Admin> admins = new List<Admin>();

            foreach (Admin admin in admins)
            {
                admins.Add(admin);
            }

            Admin AdminToChange = Prompt.Select("Please select the admin", admins);

            foreach (Admin admin in admins)
            {
                if (AdminToChange == admin)
                {
                    admin.Fname = Prompt.Input<string>("Enter a new first name");
                    admin.Lname = Prompt.Input<string>("Enter a new last name");
                    admin.Username = Prompt.Input<string>("Enter a new username");
                    admin.Password = Prompt.Input<string>("Enter a new password");
                }
                Console.WriteLine(admin);
            }
        }

        static void UpdateCleaning(List<Cleaning> CleaningList)
        {

            List<Cleaning> Cleaners = new List<Cleaning>();

            foreach (Cleaning Clean in CleaningList)
            {
                Cleaners.Add(Clean);
            }

            Cleaning CleanerToChange = Prompt.Select("Select the cleaner to change", Cleaners);

            foreach (Cleaning cleaner in CleaningList)
            {
                if (CleanerToChange == cleaner)
                {
                    Console.WriteLine("Test");
                    Console.WriteLine(1);
                    cleaner.Fname = Prompt.Input<string>("Enter a new first name");
                    Console.WriteLine(2);
                    cleaner.Lname = Prompt.Input<string>("Enter a new last name");
                    cleaner.Username = Prompt.Input<string>("Enter a new username");
                    cleaner.Password = Prompt.Input<string>("Enter a new password");
                }
                Console.WriteLine(cleaner);
            }
        }

        static void UpdateCustomer(List<Customer> CustomerList)
        {
            string[] Customers = {};

            foreach (Customer name in CustomerList)
            {
                Customers.ToArray();
            }

            Customer CustomerToChange = Prompt.Select("Please select the customer", CustomerList);

            foreach (Customer customer in CustomerList)
            {
                if (CustomerToChange == customer)
                {
                    customer.Fname = Prompt.Input<string>("Enter a new first name");
                    customer.Lname = Prompt.Input<string>("Enter a new last name");

                    Console.WriteLine(customer);
                }
            }
        }

        static void UpdateBuilding(List<Building>BuildingList, List<Customer> CustomerList)
        {
            string[] Customers = { };

            foreach (Customer name in CustomerList)
            {
                Customers.ToArray();
            }

            string[] Buildings = { };
            Nature[] Type =
            {
                Nature.DOMESTIC,
                Nature.COMMERCIAL
            };

            foreach (Building building in BuildingList)
            {
                Buildings.ToArray();
            }

            //string CustomerToEdit = Prompt.Input<string>("");

            Building BuildingToChange = Prompt.Select("Please select the customer", BuildingList);

            foreach (Building building in BuildingList)
            {
                if (BuildingToChange == building)
                {
                    building.Address = Prompt.Input<string>("Enter a new Address");
                    building.Type = Prompt.Select("Enter a new building type", Type);
                    building.CurrentCustomer = Prompt.Select("Please select a new customer", CustomerList);

                    foreach (Service service in building.Services)
                    {
                        Console.WriteLine(service);
                        service.ServiceName = Prompt.Input<string>("Enter a new service name");
                        service.Customer = building.CurrentCustomer;

                        string[] CompleteOptions =
                        {
                            "Yes",
                            "No"
                        };

                        string Choice = Prompt.Select("Is the service complete?", CompleteOptions);

                        switch (Choice)
                        {
                            case ("Yes"):
                                service.Complete = true;
                                break;
                            case ("No"):
                                service.Complete = false;
                                break;
                        }
                    }

                    Console.WriteLine(building);
                }
            }
        }

        static void AddTimeLog(List<Cleaning> CleaningList, List<TimeLog> TimeLoglist)
        {
            List<Cleaning> Clean = new List<Cleaning>();

            Cleaning Cleaner = Prompt.Select("Select the member of staff", Clean);

            TimeLog NewLog = new TimeLog(Cleaner);
        }

        static void ViewTimeLog(List<TimeLog> TimeLogList)
        {
            foreach (TimeLog Logs in TimeLogList)
            {
                Console.WriteLine(Logs);
            }
        }
        static void Quit()
        {

        }
    }
}