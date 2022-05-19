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
        private e_EngineType m_EngineType;

        public SupportedVehicles(e_VehicleType i_VehicleType, e_EngineType i_EngineType)
        {
            this.m_VehicleType = i_VehicleType;
            this.m_EngineType = i_EngineType;
        }

        public e_VehicleType VehicleType
        {
            get
            {
                return this.m_VehicleType;
            }
            set
            {
                this.m_VehicleType = value;
            }
        }

        public e_EngineType EngineType
        {
            get
            {
                return this.m_EngineType;
            }
            set
            {
                this.m_EngineType = value;
            }
        }
    }
}
