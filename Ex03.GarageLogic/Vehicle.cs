using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Vehicle
    {
        protected readonly string m_ModelName;
        protected readonly string m_LicenseNumber;
        protected float m_RemainingEnergy;
        protected Wheel m_Wheel;

        public Vehicle(string i_ModelName, string i_LicenseNumber, float i_RemainingEnergy, string i_Manufacturer, float i_CurrenttAirPressure, float i_MaxAirPressure)
        {
            this.m_ModelName = i_ModelName;
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_RemainingEnergy = i_RemainingEnergy;
            this.m_Wheel = new Wheel(i_Manufacturer, i_CurrenttAirPressure, i_MaxAirPressure);
        }

        string ModelName
        {
            get
            {
                return this.m_ModelName;
            }
        }

        string LicenseNumber
        {
            get
            {
                return this.m_LicenseNumber;
            }
        }

        float RemainingEnergy
        {
            get
            {
                return this.m_RemainingEnergy;
            }
            set
            {
                this.m_RemainingEnergy = value;
            }
        }

        Wheel Wheel
        {
            get
            {
                return this.m_Wheel;
            }
            set
            {
                this.m_Wheel = value;
            }
        }
    }
}
