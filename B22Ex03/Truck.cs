using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Truck : Vehicle
    {
        private const int c_MaxAirPressure = 24;
        private bool m_ContainedCoolCargo;
        private float m_TankVolume;
        public Truck(string i_LicenseNumber, int i_NumberWheels)
            : base(i_LicenseNumber, i_NumberWheels, c_MaxAirPressure)

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
                return this.TankVolume;
            }
            set
            {
                this.TankVolume = value;
            }
        }
    }
}
