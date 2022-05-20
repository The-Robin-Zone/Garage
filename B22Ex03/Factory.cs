using System;
 

namespace B22Ex03Shaked203943253Fanny337957633
{

    public static class Factory
    {
        internal static Vehicle CreateNewVehicle(string i_LicenseNumber,
            e_VehicleType i_VehicleType, e_EngineType i_EngineType, e_FuelType? i_FuelType)
        {

            Vehicle newVehicle = null;
            Engine newEngine = CreateEngine(i_EngineType, i_FuelType);


            switch (i_VehicleType)
            {
                case e_VehicleType.Car:
                    newVehicle = new Car(i_LicenseNumber, newEngine);
                    break;

                case e_VehicleType.Motorcycle:
                    newVehicle = new Motorcycle(i_LicenseNumber, newEngine);
                    break;

                case e_VehicleType.Truck:
                    newVehicle = new Truck(i_LicenseNumber, newEngine);
                    break;
            }

            return newVehicle;
        }

        private static Engine CreateEngine(e_EngineType i_EngineType, e_FuelType? i_FuelType)
        {
            Engine newEngine = null;
            switch (i_EngineType)
            {
                case e_EngineType.Fuel:
                    newEngine = new FuelEngine((e_FuelType)i_FuelType);
                    break;

                case e_EngineType.Electric:
                    newEngine = new ElectricEngine();
                    break;

                default:
                    newEngine = null;
                    break;
            }

            return newEngine;
        }
    }
}
