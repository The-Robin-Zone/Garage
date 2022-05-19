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
        private e_LicenseType m_LicenseType;
        private int m_EngineVolume;
        private Engine m_TypeEnergy;
        public Motorcycle(string i_LicenseNumber, int i_NumberWheels)
            : base(i_LicenseNumber, c_MaxAirPressure)
        { 

        }

        e_LicenseType LicenseType
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

        int EngineVolume
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

        Engine TypeEnergy
        {
            get
            {
                return this.m_TypeEnergy;
            }
            set
            {
                this.m_TypeEnergy = value;
            }
        }


    }
}
