using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sharprompt;
using static Shauns_Cleaning_Service_Assignment.Enums;

namespace Shauns_Cleaning_Service_Assignment
{
    //Defining the public static class CLI
    public static class CLI
    {
        static void Main(string[] args) //Definf the Mian function, wich will be the first thing to run when the progrma is run
        {
            CleaningSystem cs = new CleaningSystem("Shaun Cleans");

            //Declaring all of the lists for each class so that data can be stored within the program
            //This is to replicate a database, since there is no attached database to this program
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
            List<MajorProblem> MajorProblemList = new List<MajorProblem>();
            List<MinorProblem> MinorProblemList = new List<MinorProblem>();

            List<string> names = new List<string>();

            //Declaring some basic data to bstare within the program so that there is already some data stored within it
            //This is to stop some issues further down wthin the code, and helps a lot with testing
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

            MainMenu(Admins, Bookings, Cleaners, Purchases, Buildings, Services, Customers, TimeLogs, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
        }

        static void MainMenu(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList, List<Purchase> PurchaseList, List<Building> BuildingList, List<Service> ServiceList, List<Customer> CustomerList, List<TimeLog> TimeLogList, List<MajorProblem> MajorProblemList, List<MinorProblem> MinorProblemList)
        {
            //Declares a string array 
            string[] Options =
            {
                "View Time Log",
                "View Buildings",
                "Add New Purchase",
                "Add Time Log",
                "Add Staff Member",
                "Add Service",
                "Add Building",
                "Add Major Problem",
                "Add Minor Problem",
                "Update Information",
                "Quit"
            };

            string MenuOptions = Prompt.Select("Welcome to Shauns Cleaning Services!", Options);

            switch (MenuOptions)
            {
                case ("Update information"):
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Add Time Log"):
                    AddTimeLog(CleaningList, TimeLogList); //Runs the function AddTimeLog
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("View time log"):
                    ViewTimeLog(TimeLogList); //Runs the function ViewTimeLog
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Add New Purchase"):
                    AddNewPurchase(AdminList, BookingList, CleaningList, PurchaseList); //Runs the function AddNewPurchase
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Add Major Problem"):
                    AddMajorProblem(ServiceList, MajorProblemList); //Runs the function AddMajorProblem
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Add Minor Problem"):
                    AddMinorProblem(ServiceList, MinorProblemList); //Runs the function AddMinorProblem
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Add Staff Member"):
                    AddStaffMember(AdminList, BookingList, CleaningList); //Runs the function AddStaffMember
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Add Building"):
                    AddBuilding(BuildingList, CustomerList); //Runs the function AddBuilding
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("View Buildings"):
                    ViewBuildings(BuildingList); //Runs the function ViewBuildings
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Add Service"):
                    AddService(BuildingList, ServiceList); //Runs the function AddService
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Update Information"):
                    UpdateInformation(CustomerList, BuildingList, AdminList, CleaningList); //Runs the function UpdateInformation
                    MainMenu(AdminList, BookingList, CleaningList, PurchaseList, BuildingList, ServiceList, CustomerList, TimeLogList, MajorProblemList, MinorProblemList); //Runs the function MainMenu()
                    break;
                case ("Quit"):
                    Console.WriteLine("Quitting"); //Prints out "Quitting" in the console
                    break;

            }
        }

        //Creates a new function AddStaffMember
        //The function requires 3 lists, List<Admin>, List<Booking>, List<Cleaning>
        static void AddStaffMember(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList)
        {
            //Defining a string array called StaffTypes
            string[] StaffTypes =
            {
                "Admin",
                "Cleaning",
                "Booking"
            };

            //Declaring the main variables for ths function

            string FirstName = Prompt.Input<string>("Staff First Name");
            string LastName = Prompt.Input<string>("Staff Last Name");
            string Username = Prompt.Input<string>("Staff Username");
            string Password = Prompt.Input<string>("Staff Password");

            //While loop to call uponthe CheckUsername function until it returns true
            while (CheckUsername(AdminList, BookingList, CleaningList, Username) == false)
            {
                Username = Prompt.Input<string>("New username");
            }


            //Select prompt to find out what kind of staff type the user is adding
            string StaffOptions = Prompt.Select("What type of staff member are you adding?", StaffTypes);

            //Switch statement using the string StaffOptions
            switch (StaffOptions)
            {
                case ("Admin"):
                    Admin NewAdmin = new Admin(FirstName, LastName, Username, Password); //Creates a new Admin
                    AdminList.Add(NewAdmin); //Adds NewAdmins to the Admin list
                    break; //Stops the switch statement
                case ("Cleaning"):
                    Cleaning NewCleaning = new Cleaning(FirstName, LastName, Username, Password); //Creates a new Cleaning
                    CleaningList.Add(NewCleaning); //Adds NewCleaning to the cleaning list
                    break; //Stops the switch statement
                case ("Booking"):
                    Booking NewBooking = new Booking(FirstName, LastName, Username, Password); //Creates a new Booking
                    BookingList.Add(NewBooking); //Adds NewBooking to the booking list
                    break; //Stops the switch statement
            }
        }

        //Creates a new function CheckUsername
        //The function requires 1 string and 3 lists, List<Admin>, List<Booking>, List<Cleaning>
        static bool CheckUsername(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList, string Username)
        {
            //Foreach loop to check all of the usernames in the List<Admin> AdminList>
            foreach (Admin admin in AdminList)
            {
                //Nested if statement comparing the Admin's username the the inputted username
                if (admin.Username == Username)
                {
                    //Prints out to the console "Invalid username. Please enter a new one"
                    Console.WriteLine("Invalid username. PLease enter a new one");
                    return false; //Returns the function as false
                }
            }

            //Foreach loop to check all of the usernames in the List<Cleaning> CleaningList>
            foreach (Cleaning cleaner in CleaningList)
            {
                //Nested if statement comparing the Cleaning's username the the inputted username
                if (cleaner.Username == Username)
                {
                    //Prints out to the console "Invalid username. Please enter a new one"
                    Console.WriteLine("Invalid username. PLease enter a new one");
                    return false; //Returns the function as false
                }
            }

            //Foreach loop to check all of the usernames in the List<Booking> BookingList>
            foreach (Booking booking in BookingList)
            {
                //Nested if statement comparing the Booking's username the the inputted username
                if (booking.Username == Username)
                {
                    //Prints out to the console "Invalid username. Please enter a new one"
                    Console.WriteLine("Invalid username. PLease enter a new one");
                    return false; //Returns the function as false
                }
            }

            return true;
        }

        //Creates a new function AddNewPurchase
        //The function requires 4 lists, List<Admin>, List<Booking>, List<Cleaning>, List<Purchase>
        static void AddNewPurchase(List<Admin> AdminList, List<Booking> BookingList, List<Cleaning> CleaningList, List<Purchase> PurchaseList)
        {
            //Asks the user for the cleaners username
            string CleanerUsername = Prompt.Input<string>("What is the cleaners username");
            bool found = false; //Defines a new bool variable as false

            //Foreach loop to find the entered cleaner username
            foreach (Cleaning Cleaner in CleaningList)
            {
                //Nested if statement to compare the inputted username with the list's cleaner's username
                if (Cleaner.Username == CleanerUsername)
                {
                    //Declared a new Cleaning variable
                    Cleaning TargetCleaner = Cleaner;
                    found = true; //Changes the bool found to true

                    //Asks the user for the new Purchase attributes
                    string Description = Prompt.Input<string>("Purchase Description");
                    double Cost = Prompt.Input<double>("Purchase cost");

                    //Created a new Purchase class
                    Purchase NewPurchase = new Purchase(Description, Cost, TargetCleaner);
                    
                    //Adds NewPurchase the the List<Purchase> PurchaseList
                    PurchaseList.Add(NewPurchase);
                }
            }

            //if statement
            if(found == false)
            {
                //Prints to the console "{CleanerUsername} cleaner was not found"
                Console.WriteLine($"{CleanerUsername} cleaner was not found");
            }
        }

        //Creates a new function AddBuilding
        //The function requires 2 lists, List<Building>, List<Customer>
        static void AddBuilding(List<Building> BuildingList, List<Customer> CustomerList)
        {
            //Creating a new enum Nature array
            Nature[] Types = { Nature.DOMESTIC, Nature.COMMERCIAL};

            //Asks for the users
            string Fname = Prompt.Input<string>("Customer First Name");
            string Lname = Prompt.Input<string>("Customer Last Name");
            string Address = Prompt.Input<string>("Building Address");

            Nature Type = Prompt.Select("Type of Building", Types);
            Customer customer = new Customer(Fname, Lname);

            Building Newuilding = new Building(Address, Type, customer);

            CustomerList.Add(customer);
            BuildingList.Add(Newuilding);
        }

        //Creates a new function AddService
        //The function requires 2 lists, List<Building>, List<Service>
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

                    string ProblemType = Prompt.Select("", new[] {"Minor", "Major"});

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

        //Creates a new function AddMajorProblem
        //The function requires 2 lists, List<Service>, List<MajorProblem>
        static void AddMajorProblem(List<Service> ServiceList, List<MajorProblem> MajorProblemList)
        {
            List<Service> Services = new List<Service>();

            foreach (Service Service in ServiceList)
            {
                Services.Add(Service);
            }

            Service ServiceToAdd = Prompt.Select("Pick the service to add", Services);

            foreach (Service Service in Services)
            {
                if (ServiceToAdd == Service)
                {
                    string IsOpen = Prompt.Input<string>("Is the issue open", new[] { "Yes", "No"});
                    bool Open = false;

                    //Switch statement using the bool IsOpen
                    switch (IsOpen)
                    {
                        case ("Yes"):
                            Open = true;
                            break;
                        case ("No"):
                            Open = false;
                            break;
                    }
                    MajorProblem NewProblem = new MajorProblem(Service, Open);
                    MajorProblemList.Add(NewProblem);
                }
            }
        }

        //Creates a new function AddMinorProblem
        //The function requires 2 lists, List<Service>, List<MinorProblem>
        static void AddMinorProblem(List<Service> ServiceList, List<MinorProblem> MinorProblemList)
        {
            List<Service> Services = new List<Service>();

            foreach (Service Service in ServiceList)
            {
                Services.Add(Service);
            }

            Service ServiceToAdd = Prompt.Select("Pick the service to add", Services);

            foreach (Service Service in Services)
            {
                if (ServiceToAdd == Service)
                {
                    string IsOpen = Prompt.Input<string>("Is the issue open", new[] { "Yes", "No" });
                    bool Open = false;

                    //Switch statement using the bool IsOpen
                    switch (IsOpen)
                    {
                        case ("Yes"):
                            Open = true;
                            break;
                        case ("No"):
                            Open = false;
                            break;
                    }
                    MinorProblem NewProblem = new MinorProblem(Service, Open);
                    MinorProblemList.Add(NewProblem);
                }
            }
        }

        //Creates a new function ViewBuildings
        //The function requires 1 list, List<Building>
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


        //Creates a new function UpdateInformation
        //The function requires 4 lists, List<Customer>, List<Building>, List<Admin>, List<Cleaning>
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

            //Switch statement using the string UpdateChoice
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

        //Creates a new function UpdateCleaning
        //The function requires 1 lists, List<Cleaning>
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

        //Creates a new function UpdateCustomer
        //The function requires 1 lists, List<Customer>
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

        //Creates a new function UpdateBuiding
        //The function requires 2 lists, List<Building>, List<Customer>
        static void UpdateBuilding(List<Building>BuildingList, List<Customer> CustomerList)
        {
            //Declaring a new string array Customers
            string[] Customers = { };

            //Foreach loop tha runs through the items in List<Customer> CustomerList and adds them into the new array
            foreach (Customer name in CustomerList)
            {
                Customers.ToArray(); //Adds the currently selected Customer to the Customers array
            }

            //Declares a new string array Buildings
            string[] Buildings = { };
            
            //Declares a new enum Nature array
            Nature[] Type =
            {
                Nature.DOMESTIC,
                Nature.COMMERCIAL
            };

            //Foreach loop that runs through each item in the list <Building> BuildingList
            foreach (Building building in BuildingList)
            {
                Buildings.ToArray(); //Adds the currently selected Building to the Buildings array
            }

            //Select prompt to ask the user what 
            Building BuildingToChange = Prompt.Select("Please select the customer", BuildingList);

            //Foreach loop that runs through each item in the List<Building> BuildingList
            foreach (Building building in BuildingList)
            {
                //Nested if statement to compare the building and the users selected building
                if (BuildingToChange == building)
                {
                    building.Address = Prompt.Input<string>("Enter a new Address");
                    building.Type = Prompt.Select("Enter a new building type", Type);
                    building.CurrentCustomer = Prompt.Select("Please select a new customer", CustomerList);

                    foreach (Service service in building.Services)
                    {
                        //Prints the service to the console
                        Console.WriteLine(service);

                        //Asks the usedr to enter the service name
                        service.ServiceName = Prompt.Input<string>("Enter a new service name");
                        //Sets the Service Customer variable to be the same as the Building CurrentCustomer variable
                        service.Customer = building.CurrentCustomer;

                        //Creates a new  strng array CompleteOptions
                        string[] CompleteOptions =
                        {
                            "Yes",
                            "No"
                        };

                        //Asks the user to choose a choice from the array CompleteOptions
                        string Choice = Prompt.Select("Is the service complete?", CompleteOptions);

                        //Switch statement using the string Choice
                        switch (Choice)
                        {
                            case ("Yes"):
                                service.Complete = true; //Changes the services Complete variable to true
                                break;
                            case ("No"):
                                service.Complete = false; //Changes the services Complete variable to false
                                break;
                        }
                    }

                    //Prints out the updated building class
                    Console.WriteLine(building);
                }
            }
        }

        //Creates a new function AddTimeLog
        //The function requires 2 lists, List<Cleaning>, List<TimeLog>
        static void AddTimeLog(List<Cleaning> CleaningList, List<TimeLog> TimeLoglist)
        {

            //Asks the user to select the staff member from the list of staff members provided
            Cleaning Cleaner = Prompt.Select("Select the member of staff", CleaningList);

            //Cleates a new TimeLog for the selected Cleaner
            TimeLog NewLog = new TimeLog(Cleaner);
            //Adds the new TimeLog to the List<TimeLog> TimeLogList
            TimeLoglist.Add(NewLog);
        }

        //Creates a new function ViewTimeLog
        //The function requires 1 lists, List<TimeLog>,
        static void ViewTimeLog(List<TimeLog> TimeLogList)
        {
            //Foreach loop that prints out all of the TimeLogs storred in List<TimeLog> TimeLogList
            foreach (TimeLog Logs in TimeLogList)
            {
                Console.WriteLine(Logs);
            }
        }
    }
}