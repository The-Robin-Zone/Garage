﻿using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Program
    {
        public static void Main()
        {
            //GarageMenu newGarage = new GarageMenu();
            //newGarage.OpenGarageMenu();


            string i_LicenseNumber = "1992";
            e_VehicleType i_VehicleType = e_VehicleType.Car;
            e_EngineType i_EngineType = e_EngineType.Fuel;
            e_FuelType? i_FuelType = e_FuelType.Octane95;


            Vehicle shaked = Factory.CreateNewVehicle(i_LicenseNumber, i_VehicleType, i_EngineType, i_FuelType);

            
            Console.WriteLine(shaked.ToString());

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            shaked.ModelName = "Ferari";
            shaked.VehicleInfo.StatusVehicule = e_StatusVehicle.Repaired;
            shaked.VehicleInfo.OwnerPhoneNumber = "0542008871";
            shaked.VehicleInfo.OwnerName = "Shaked";
            shaked.SetWheelsManufacture("Fanny wheels inc.");
            shaked.SetWheelsPSI(30);

            shaked.Engine.CurrentEnergy = 10;
        

            Console.WriteLine(shaked.ToString());


        }
    }
}
