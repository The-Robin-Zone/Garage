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
        private readonly e_LicenseType r_LicenseType;
        private readonly int m_EngineVolume;
        private Engine m_TypeEnergy;
        public Motorcycle(string i_ModelName, string i_LicenseNumber, float i_RemainingEnergy, string i_Manufacturer, float i_CurrenttAirPressure, int i_LicenseType, int i_EngineVolume, Engine i_TypeEnergy)
        : base(i_ModelName, i_LicenseNumber, i_RemainingEnergy, i_Manufacturer, i_CurrenttAirPressure, c_MaxAirPressure)
        {
            this.r_LicenseType = (e_LicenseType)i_LicenseType;
            this.m_EngineVolume = i_EngineVolume;
            this.m_TypeEnergy = i_TypeEnergy;

        }

        e_LicenseType LicenseType
        {
            get
            {
                return this.r_LicenseType;
            }
        }

        int EngineVolume
        {
            get
            {
                return this.m_EngineVolume;
            }
        }

        Engine TypeEnergy
        {
            get
            {
                return this.m_TypeEnergy;
            }
        }


    }
}
