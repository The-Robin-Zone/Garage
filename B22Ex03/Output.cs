using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Output
    {
        public static void MainOptions()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Garage home page");
            Console.WriteLine("Please select one of the following opetions:");
            Console.WriteLine("1) Insert a new Vehicle");
            Console.WriteLine("2) Display a list of license numbers - filter by vehicle status");
            Console.WriteLine("3) Change Vehicle Status");
            Console.WriteLine("4) Inflate tires");
            Console.WriteLine("5) Refuel vehicle");
            Console.WriteLine("6) Recharge vehicle");
            Console.WriteLine("7) Display vehicle information");
            Console.WriteLine("8) Exit System");
            //Console.WriteLine("you can type \"home\" at every stage to come back to this page.");
            Console.WriteLine();

        }

        public static void InvalidInputPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a valid input");
            Console.WriteLine();
        }

        public static void ExitProgPromt()
        {
            Console.WriteLine();
            Console.WriteLine("Thank you for using the garge managment system!");
            Console.WriteLine("See you next time");
            Console.ReadLine();
        }

        public static void VehiclesToDisplay()
        {
            Console.WriteLine();
            Console.WriteLine("Which vehicles would you like to display?");
            Console.WriteLine("1) All Vehicles in the garage");
            Console.WriteLine("2) In-Repair");
            Console.WriteLine("3) Repaired");
            Console.WriteLine("4) Payed for");
            Console.WriteLine();

        }

        public static void VehiclesStatus()
        {
            Console.WriteLine();
            Console.WriteLine("1) In-Repair");
            Console.WriteLine("2) Repaired");
            Console.WriteLine("3) Payed for");
            Console.WriteLine();

        }
    }
}
