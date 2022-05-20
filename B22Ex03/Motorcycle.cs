using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_LicenseType
    {
        A = 1,
        A1 = 2,
        B1 = 3,
        BB = 4
    }

    public class Motorcycle : Vehicle
    {
        private const int c_MaxAirPressure = 31;
        private const int c_NumberWheels = 2;
        private const float c_MaxFuelTank = 38F;
        private const float c_MaxBatteryLife = 3.3F;
        private e_LicenseType m_LicenseType;
        private int m_EngineVolume;
        public Motorcycle(string i_LicenseNumber, Engine i_Engine) : base(i_LicenseNumber, i_Engine, c_MaxAirPressure, c_NumberWheels, c_MaxFuelTank, c_MaxBatteryLife)
        { 

        }

        public e_LicenseType LicenseType
        {
            get
            {
                return this.m_LicenseType;
            }
            set
            {
                this.m_LicenseType = value;
            }
        }

        public int EngineVolume
        {
            get
            {
                return this.m_EngineVolume;
            }
            set
            {
                this.m_EngineVolume = value;
            }
        }

        public override string ToString()
        {
            return string.Format(base.ToString() + "\nMotorcycle Details: \nLicenseType: {0}, EngineVolume: {1} cc",
                m_LicenseType.ToString(), m_EngineVolume);
        }
    }
}
