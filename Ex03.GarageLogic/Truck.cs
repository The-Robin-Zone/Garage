using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Truck : Vehicle
    {
        private const int c_MaxAirPressure = 24;
        private bool m_ContainedCoolCargo;
        private readonly float r_TankVolume;
        public Truck(string i_ModelName, string i_LicenseNumber, float i_RemainingEnergy,
            string i_Manufacturer, float i_CurrenttAirPressure, float i_MaxAirPressure, bool i_ContainedCoolCargo, float i_TankVolume)
            : base(i_ModelName, i_LicenseNumber, i_RemainingEnergy, i_Manufacturer, i_CurrenttAirPressure, c_MaxAirPressure)

        {
            this.m_ContainedCoolCargo = i_ContainedCoolCargo;
            this.r_TankVolume = i_TankVolume;
        }

        bool ContainedCoolCargo
        {
            get
            {
                return this.m_ContainedCoolCargo;
            }
            set
            {
                this.m_ContainedCoolCargo = value;
            }
        }

        float TankVolume
        {
            get
            {
                return this.TankVolume;
            }
        }
    }
}
