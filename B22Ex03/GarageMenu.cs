using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    internal class GarageMenu
    {
        Garage m_Garage = new Garage();
        bool inGarageMenue;

        public void OpenGarageMenu()
        {
            this.inGarageMenue = true;

            while (inGarageMenue)
            {
                Output.MainOptions();
                int UserChoice = Input.GetUserOption(8);

                switch (UserChoice)
                {
                    case 1:
                        InsertNewVehicle();
                        break;

                    case 2:
                        DisplayLicenseNumbers();
                        break;

                    case 3:
                        ChangeVehicleStatus();
                        break;

                    case 4:
                        InflateTires();
                        break;

                    case 5:
                        RefuelVehicle();
                        break;

                    case 6:
                        RechargeVehicle();
                        break;

                    case 7:
                        DisplayVehicleInfo();
                        break;

                    case 8:
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
            foreach (SupportedVehicles cartype in this.m_Garage.TypeOfVehicleHandle)
            {
                Console.Write(i + ") ");
                Console.WriteLine(cartype);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("Insert a license number:");
            userLicenseNumber = Console.ReadLine();

            // Vehicle already exists in garage
            if (m_Garage.IsVehiculeInGarage(userLicenseNumber))
            {
                Console.WriteLine("Vehicle is already in the Garage, Chaning status to \"In-Repair\"...");
                m_Garage.UpdateStatus(userLicenseNumber, e_StatusVehicle.InRepair);
                Console.ReadLine();
            }
            // Create a new vehicle and add to garage
            else
            {
                Console.WriteLine("Which vehicle would you like to make? (enter a number from available vehicles)");
                userVehicleChoice = Input.GetUserOption(this.m_Garage.TypeOfVehicleHandle.Count);

                newVehicle = Factory.CreateNewVehicle(userLicenseNumber,
                    this.m_Garage.TypeOfVehicleHandle[userVehicleChoice - 1].VehicleType,
                    this.m_Garage.TypeOfVehicleHandle[userVehicleChoice - 1].EngineType);


                this.m_Garage.AddNewVehicule(userLicenseNumber, newVehicle);

                // Initialize vehicle fields
                VehicleInfoUpdate(userLicenseNumber);

                Console.WriteLine("The vehicle was succesfully added to the Garage!");

                Console.WriteLine();
                Console.WriteLine(newVehicle);
                Console.WriteLine();
                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }

            Console.Clear();

        }

        public void DisplayLicenseNumbers()
        {
            int userVehicleChoice;

            Output.VehiclesToDisplay();

            userVehicleChoice = Input.GetUserOption(4);

            switch (userVehicleChoice)
            {
                case 1:
                    Console.WriteLine(this.m_Garage.AllLicensedNumber());
                    break;

                case 2:
                    Console.WriteLine(this.m_Garage.AllLicensedNumberByFilter(e_StatusVehicle.InRepair));
                    break;

                case 3:
                    Console.WriteLine(this.m_Garage.AllLicensedNumberByFilter(e_StatusVehicle.Repaired));
                    break;

                case 4:
                    Console.WriteLine(this.m_Garage.AllLicensedNumberByFilter(e_StatusVehicle.PayedFor));
                    break;

                default:
                    break;

            }
        }

            public void ChangeVehicleStatus()
            {
                string userInput = string.Empty;
                int userVehicleChoice;
                bool isVehicleinGarage;
                Console.WriteLine("Enter a license number:");
                userInput = Console.ReadLine();
                isVehicleinGarage = this.m_Garage.IsVehiculeInGarage(userInput);

                if (isVehicleinGarage)
                {
                    Console.WriteLine("To which status would you like to change the vehicle?");
                    Output.VehiclesStatus();
                    userVehicleChoice = Input.GetUserOption(3);

                    switch (userVehicleChoice)
                    {
                        case 1:
                            this.m_Garage.UpdateStatus(userInput, e_StatusVehicle.InRepair);
                            Console.WriteLine("Status Changed");
                            break;

                        case 2:
                            this.m_Garage.UpdateStatus(userInput, e_StatusVehicle.Repaired);
                            Console.WriteLine("Status Changed");
                            break;

                        case 3:
                            this.m_Garage.UpdateStatus(userInput, e_StatusVehicle.PayedFor);
                            Console.WriteLine("Status Changed");
                            break;

                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Vehicle is not in the garage");
                }

                Console.ReadLine();
                Console.Clear();
            }

        public void InflateTires()
        {
            string userInput = string.Empty;
            bool isVehicleinGarage;
            Console.WriteLine("Enter a vehicle license number to inflate tires:");
            userInput = Console.ReadLine();
            isVehicleinGarage = this.m_Garage.IsVehiculeInGarage(userInput);

            if (isVehicleinGarage)
            {
                this.m_Garage.InflateWheels(userInput);
                Console.WriteLine("Tires were inlated");
            }
            else
            {
                Console.WriteLine("Vehicle is not in the garage");
            }

            Console.ReadLine();
            Console.Clear();
        }

        public void RefuelVehicle()
        {
            string userLicensePlate = string.Empty;
            bool isVehicleinGarage;
            float fuelToAdd;
            e_FuelType fuelType;

            Console.WriteLine("Enter a vehicle license number to refuel:");
            userLicensePlate = Console.ReadLine();
            isVehicleinGarage = this.m_Garage.IsVehiculeInGarage(userLicensePlate);

            if (isVehicleinGarage)
            {
                Console.WriteLine("How much fuel would you like to fill?");
                fuelToAdd = Input.GetUserFloat();
                Console.WriteLine("Which fuel type would you like to fill?");
                fuelType = Input.GetUserFuelType();
                this.m_Garage.Refuel(userLicensePlate, (e_FuelType)fuelType, fuelToAdd);
                Console.WriteLine("Vehicle refuled");
            }
            else
            {
                Console.WriteLine("Vehicle is not in the garage");
            }

            Console.ReadLine();
            Console.Clear();
        }

        public void RechargeVehicle()
        {
            string userLicensePlate = string.Empty;
            bool isVehicleinGarage;
            float energyToAdd;
            
            Console.WriteLine("Enter a vehicle license number to recharge:");
            userLicensePlate = Console.ReadLine();
            isVehicleinGarage = this.m_Garage.IsVehiculeInGarage(userLicensePlate);

            if (isVehicleinGarage)
            {
                Console.WriteLine("How many minutes would you like to charge?");
                energyToAdd = Input.GetUserFloat();
                this.m_Garage.Recharge(userLicensePlate, energyToAdd);
                Console.WriteLine("Vehicle Recharged");
            }
            else
            {
                Console.WriteLine("Vehicle is not in the garage");
            }

            Console.ReadLine();
            Console.Clear();

        }

        public void DisplayVehicleInfo()
        {
            string userLicensePlate = string.Empty;
            bool isVehicleinGarage;

            Console.WriteLine("Enter a license number:");
            userLicensePlate = Console.ReadLine();
            isVehicleinGarage = this.m_Garage.IsVehiculeInGarage(userLicensePlate);

            if (isVehicleinGarage)
            {
                Console.WriteLine(this.m_Garage.VehiclesInGarage[userLicensePlate]);
            }
            else
            {
                Console.WriteLine("Vehicle is not in the garage");
            }

            Console.ReadLine();
            Console.Clear();
        }

        public void VehicleInfoUpdate(string i_LicenseNumber)
        {
            Console.WriteLine("Insert Model name:");
            m_Garage.VehiclesInGarage[i_LicenseNumber].ModelName = Console.ReadLine();
            Console.WriteLine("Insert owner name:");
            m_Garage.VehiclesInGarage[i_LicenseNumber].VehicleInfo.OwnerName = Console.ReadLine();
            Console.WriteLine("Insert Owner Phone Number name:");
            m_Garage.VehiclesInGarage[i_LicenseNumber].VehicleInfo.OwnerPhoneNumber = Console.ReadLine();
            Console.WriteLine("Insert Wheel Manuufacturer name:");
            m_Garage.VehiclesInGarage[i_LicenseNumber].SetWheelsManufacture(Console.ReadLine());


            if (m_Garage.VehiclesInGarage[i_LicenseNumber] is Motorcycle)
            {
                Console.WriteLine("Insert License Type:");
                ((Motorcycle)m_Garage.VehiclesInGarage[i_LicenseNumber]).LicenseType = Input.GetUserLicenseType();
                Console.WriteLine("Insert Engine Volume:");
                ((Motorcycle)m_Garage.VehiclesInGarage[i_LicenseNumber]).EngineVolume = Input.GetUserInt();
            }
            if (m_Garage.VehiclesInGarage[i_LicenseNumber] is Car)
            {
                Console.WriteLine("Insert Vehicle Color:");
                ((Car)m_Garage.VehiclesInGarage[i_LicenseNumber]).ColorVehicle = Input.GetUserVehicleColor();
                Console.WriteLine("Insert Number of Doors:");
                ((Car)m_Garage.VehiclesInGarage[i_LicenseNumber]).NumberOfDoors = Input.GetUserNumberOfDoors();
            }
            if (m_Garage.VehiclesInGarage[i_LicenseNumber] is Truck)
            {
                Console.WriteLine("Does truck contain cooled cargo?:");
                ((Truck)m_Garage.VehiclesInGarage[i_LicenseNumber]).ContainedCoolCargo = Input.GetUserBool();
                Console.WriteLine("Insert Tank Volume:");
                ((Truck)m_Garage.VehiclesInGarage[i_LicenseNumber]).TankVolume = Input.GetUserFloat();
            }

            Console.Clear();

        }
    }
}
