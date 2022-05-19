using System;
 

namespace B22Ex03Shaked203943253Fanny337957633
{

    public static class Factory
    {
        internal static Vehicle CreateNewVehicle(string i_ModelName, string i_LicenseNumber,
            SupportedVehicles.e_VehicleType i_VehicleType, Engine.e_EngineType i_EngineType, FuelEngine.e_FuelType? i_FuelType, float i_CurrentEnergyCapcity,
            float i_MaxEnergyCapacity, string i_WheelManufactor, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            Vehicle newVehicle = null;
            Engine engine = CreateEngine(i_EngineType, i_FuelType, i_MaxEnergyCapacity, i_CurrentEnergyCapcity);
            Wheel wheel = new Wheel(i_WheelManufactor, i_CurrentAirPressure, i_MaxAirPressure);

            switch (i_VehicleType)
            {
                case SupportedVehicles.e_VehicleType.Car:
                    newVehicle = new Car(i_ModelName, i_LicenseNumber, engine, wheel);
                    break;

                case SupportedVehicles.e_VehicleType.Motorcycle:
                    newVehicle = new Motorcycle(i_ModelName, i_LicenseNumber, engine, wheel);
                    break;

                case SupportedVehicles.e_VehicleType.Truck:
                    newVehicle = new Truck(i_ModelName, i_LicenseNumber, engine, wheel);
                    break;
            }

            return newVehicle;
        }

        private static Engine CreateEngine(Engine.e_EngineType i_EngineType, FuelEngine.e_FuelType? i_FuelType,
            float i_MaxEnergyCapacity, float i_CurrentEnergyCapcity)
        {
            Engine engine;
            switch (i_EngineType)
            {
                case Engine.e_EngineType.Gasoline:
                    engine = new FuelEngine(i_CurrentEnergyCapcity, i_MaxEnergyCapacity, (FuelEngine.e_FuelType)i_FuelType);
                    break;

                case Engine.e_EngineType.Electric:
                    engine = new ElectricEngine(i_CurrentEnergyCapcity, i_MaxEnergyCapacity);
                    break;

                default:
                    engine = null;
                    break;
            }

            return engine;
        }
    }
}
