using System;
using System.Collections.Generic;


namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Vehicle
    {
        protected readonly string r_ModelName;
        protected readonly string r_LicenseNumber;
        protected float m_RemainingEnergy;
        protected VehicleInfo m_VehicleInfo;
        protected List<Wheel> m_Wheels;

        public Vehicle(string i_ModelName, string i_LicenseNumber, float i_RemainingEnergy,
            string i_OwnerName, string i_OwnerPhoneNumber, int i_NumberWheels,
            string i_ManufactureName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            this.r_ModelName = i_ModelName;
            this.r_LicenseNumber = i_LicenseNumber;
            this.m_RemainingEnergy = i_RemainingEnergy;
            this.m_VehicleInfo = new VehicleInfo(i_OwnerName, i_OwnerPhoneNumber);
            this.m_Wheels = new List<Wheel>();
            for (int i = 0; i < i_NumberWheels; i++)
            {
                this.m_Wheels.Add(new Wheel(i_ManufactureName, i_CurrentAirPressure, i_MaxAirPressure));
            }
        }

        string ModelName
        {
            get
            {
                return this.r_ModelName;
            }
        }

        string LicenseNumber
        {
            get
            {
                return this.r_LicenseNumber;
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

        public VehicleInfo VehicleInfo
        {
            get
            {
                return this.m_VehicleInfo;
            }
            set
            {
                this.m_VehicleInfo = value;
            }
        }
    }
}
