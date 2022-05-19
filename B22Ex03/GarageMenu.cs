using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    internal class GarageMenu
    {
        Garage m_garage = new Garage();
        bool inGarageMenue;

        public void OpenGarageMenu()
        {
            this.inGarageMenue = true;

            while (inGarageMenue)
            {
                Output.MainOptions();
                int UserChoice = Input.GetHomePageChoice();

                switch (UserChoice)
                {
                    case 1:
                        InsertNewVehicle();
                        break;

                    case 2:
                        DisplayLicenseNumbers();
                        break;

                    case 3:
                        InflateTires();
                        break;

                    case 4:
                        RefuelVehicle();
                        break;

                    case 5:
                        RechargeVehicle();
                        break;

                    case 6:
                        DisplayVehicleInfo();
                        break;

                    case 7:
                        Output.ExitProgPromt();
                        Environment.Exit(0);
                        break;

                    default:
                        break;

                }
            }

        }

        public static void InsertNewVehicle()
        {
            Console.WriteLine("Insert New Vehicle...");
            
            foreach (cartype in Garage.r_SupportedVehicles)
            Console.ReadLine();
            Console.Clear();

        }

        public static void DisplayLicenseNumbers()
        {
            Console.WriteLine("Display License Numbers...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void InflateTires()
        {
            Console.WriteLine("Inflate Tires...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void RefuelVehicle()
        {
            Console.WriteLine("Refuel Vehicle...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void RechargeVehicle()
        {
            Console.WriteLine("Recharge Vehicle...");
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayVehicleInfo()
        {
            Console.WriteLine("Display Vehicle Info...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
