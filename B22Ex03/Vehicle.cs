using System;
using System.Collections.Generic;


namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Vehicle
    {
        protected string m_ModelName;
        protected readonly string r_LicenseNumber;
        protected float m_RemainingEnergy;
        protected VehicleInfo m_VehicleInfo;
        protected List<Wheel> m_Wheels;

        public Vehicle(string i_LicenseNumber, int i_NumberWheels, float i_MaxAirPressure)
        {
            this.r_LicenseNumber = i_LicenseNumber;
            this.m_VehicleInfo = new VehicleInfo();
            this.m_Wheels = new List<Wheel>();
            //for (int i = 0; i < i_NumberWheels; i++)
            //{
            //    this.m_Wheels.Add(new Wheel(i_MaxAirPressure));
            //}
        }

        string ModelName
        {
            get
            {
                return this.m_ModelName;
            }
            set
            {
                this.m_ModelName = value;
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

        public List<Wheel> Wheels
        {
            get
            {
                return this.m_Wheels;
            }
        }

        public void Inflate(float i_NbrAirToAdd)
        {
            foreach(Wheel wheel in this.m_Wheels)
            {
                wheel.CurrentAirPressure += i_NbrAirToAdd;
            }
        }
    }
}
