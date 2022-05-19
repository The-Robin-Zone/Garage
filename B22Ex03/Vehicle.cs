using System;

namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Vehicle
    {
        protected readonly string m_ModelName;
        protected readonly string m_LicenseNumber;
        protected float m_RemainingEnergy;
        protected VehicleInfo m_VehicleInfo;

        public Vehicle(string i_ModelName, string i_LicenseNumber, float i_RemainingEnergy,
            string i_OwnerName, string i_OwnerPhoneNumber)
        {
            this.m_ModelName = i_ModelName;
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_RemainingEnergy = i_RemainingEnergy;
            this.m_VehicleInfo = new VehicleInfo(i_OwnerName, i_OwnerPhoneNumber);
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
