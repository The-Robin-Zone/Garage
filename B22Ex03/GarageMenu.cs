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
                int UserChoice = Input.GetUserOption(7);

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

        public void InsertNewVehicle()
        {
            string userLicenseNumber = string.Empty;
            int userVehicleChoice;
            Vehicle newVehicle = null;
            int i = 1;

            // Prints available vehicle types
            Console.WriteLine("These are the available types");
            foreach (SupportedVehicles cartype in this.m_garage.TypeOfVehicleHandle)
            {
                Console.Write(i + ") ");
                Console.WriteLine(cartype);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Insert a license number:");
            userLicenseNumber = Console.ReadLine();

            if (m_garage.IsVehiculeInGarage(userLicenseNumber))
            {
                Console.WriteLine("Vehicle is already in the Garage, Chaning status to \"In-Repair\"...");
                m_garage.UpdateStatus(userLicenseNumber, 1);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Which vehicle would you like to make?");
                userVehicleChoice = Input.GetUserOption(this.m_garage.TypeOfVehicleHandle.Count);

                newVehicle = Factory.CreateNewVehicle(userLicenseNumber,
                    this.m_garage.TypeOfVehicleHandle[userVehicleChoice - 1].VehicleType,
                    this.m_garage.TypeOfVehicleHandle[userVehicleChoice - 1].EngineType);

                this.m_garage.AddNewVehicule(userLicenseNumber, newVehicle);
                Console.WriteLine("The vehicle was succesfully added to the Garge!");
                Console.WriteLine();
                Console.WriteLine(newVehicle);
                Console.ReadLine();
            }

            Console.Clear();

        }

        public static void DisplayLicenseNumbers()
        {
            Console.WriteLine("Display License Numbers...");
            // ask user if he want to see:
            // 1. all license numbers
            // 2. in repair
            // 3. repaired
            // 4. in repair
            // 5. payed for
            // iterate through the hash table and print 
            // 
            Console.ReadLine();
            Console.Clear();
        }

        public static void InflateTires()
        {
            Console.WriteLine("Inflate Tires...");
            // ask user for a license number
            // check license number exists
            // inflate tire if doesnt exceed max psi
            Console.ReadLine();
            Console.Clear();
        }

        public static void RefuelVehicle()
        {
            Console.WriteLine("Refuel Vehicle...");
            // ask user for a license number, fuel type, amount to fill
            // check license number exists
            // check fuel match
            // check amount doesnt exceeds max capacity if yes fill to max
            // fill
            Console.ReadLine();
            Console.Clear();
        }

        public static void RechargeVehicle()
        {
            Console.WriteLine("Recharge Vehicle...");
            // ask user for a license number and number of minutes to charge
            // check license number exists
            // check amount of minutes dont exceeds max capacity, if yes than charge max
            Console.ReadLine();
            Console.Clear();
        }

        public static void DisplayVehicleInfo()
        {
            Console.WriteLine("Display Vehicle Info...");
            // iterate through the hash map and call ToSting method on each vehicle
            Console.ReadLine();
            Console.Clear();
        }

    }
}
