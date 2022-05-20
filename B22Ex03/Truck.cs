using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Truck : Vehicle
    {
        private const int c_MaxAirPressure = 24;
        private const int c_NumberWheels = 16;
        private const float c_MaxFuelTank = 120F;
        private bool m_ContainedCoolCargo;
        private float m_TankVolume;
        public Truck(string i_LicenseNumber, Engine i_Engine) : base(i_LicenseNumber, i_Engine, c_MaxAirPressure, c_NumberWheels, c_MaxFuelTank, null)

        {

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
                return this.m_TankVolume;
            }
            set
            {
                this.m_TankVolume = value;
            }
        }
    }
}
