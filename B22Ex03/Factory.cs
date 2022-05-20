using System;
 

namespace B22Ex03Shaked203943253Fanny337957633
{

    public static class Factory
    {
        internal static Vehicle CreateNewVehicle(string i_ModelName, string i_LicenseNumber,
            e_VehicleType i_VehicleType, e_EngineType i_EngineType, e_FuelType? i_FuelType, float i_CurrentEnergyCapcity,
            float i_MaxEnergy, string i_WheelManufactor, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            Vehicle newVehicle = null;
            Engine engine = CreateEngine(i_EngineType, i_FuelType, i_MaxEnergy, i_CurrentEnergyCapcity);
            Wheel wheel = new Wheel(i_WheelManufactor, i_MaxAirPressure);

            switch (i_VehicleType)
            {
                case e_VehicleType.Car:
                    newVehicle = new Car(i_LicenseNumber);
                    break;

                case e_VehicleType.Motorcycle:
                    newVehicle = new Motorcycle(i_LicenseNumber);
                    break;

                case e_VehicleType.Truck:
                    newVehicle = new Truck(i_LicenseNumber);
                    break;
            }

            return newVehicle;
        }

        private static Engine CreateEngine(e_EngineType i_EngineType, e_FuelType? i_FuelType,
            float i_MaxEnergy, float i_CurrentEnergyCapcity)
        {
            Engine engine;
            switch (i_EngineType)
            {
                case e_EngineType.Fuel:
                    engine = new FuelEngine((e_FuelType)i_FuelType, i_MaxEnergy);
                    break;

                case e_EngineType.Electric:
                    engine = new ElectricEngine(i_MaxEnergy);
                    break;

                default:
                    engine = null;
                    break;
            }

            return engine;
        }
    }
}
