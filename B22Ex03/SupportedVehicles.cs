using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_VehicleType
    {
        Car,
        Motorcycle,
        Truck
    }

    public class SupportedVehicles
    {
        private e_VehicleType m_VehicleType;
        private int m_NumberWheels;
        private e_FuelType m_FuelType;
        private e_EngineType m_EngineType;
        private float m_MaxAirPressure;
        private float m_MaxEnergyCapacity;

        public SupportedVehicles()
        {
        }
    }
}
