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
            Console.WriteLine("3) Inflate tires");
            Console.WriteLine("4) Refuel vehicle");
            Console.WriteLine("5) Recharge vehicle");
            Console.WriteLine("6) Display vehicle information");
            Console.WriteLine("you can type \"home\" at every stage to come back to this page.");
            Console.WriteLine();

        }

        public static void InvalidInputPrompt()
        {
            Console.WriteLine();
            Console.WriteLine("Please enter a valid input");
            Console.WriteLine();
        }
    }
}
