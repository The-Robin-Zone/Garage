using System;
using System.Collections.Generic;


namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Vehicle
    {
        protected string m_ModelName;
        protected string m_LicenseNumber;
        protected VehicleInfo m_VehicleInfo;
        protected Wheel[] m_Wheels;
        protected Engine m_Engine;

        public Vehicle(string i_LicenseNumber, Engine i_engine, float i_MaxAirPressure, int i_NumberWheels, float i_MaxFuelTank, float? i_MaxBatteryLife, e_FuelType i_FuelType)
        {
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_VehicleInfo = new VehicleInfo();
            this.m_Wheels = new Wheel[i_NumberWheels];
            this.m_Engine = i_engine;
            if (this.m_Engine is FuelEngine)
            {
                this.m_Engine.MaxEnergy = i_MaxFuelTank;
                (this.m_Engine as FuelEngine).FuelType = i_FuelType;
            } else
            {
                this.m_Engine.MaxEnergy = (float)i_MaxBatteryLife;
            }
            this.m_VehicleInfo = new VehicleInfo();
            for (int i = 0; i < i_NumberWheels; i++)
            {
                this.m_Wheels[i] = new Wheel(i_MaxAirPressure);
            }
        }

        public string ModelName
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

        public string LicenseNumber
        {
            get
            {
                return this.m_LicenseNumber;
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

        public Engine Engine
        {
            get
            {
                return this.m_Engine;
            }
        }

        public Wheel[] Wheels
        {
            get
            {
                return this.m_Wheels;
            }
        }

        // Inflate all tires
        public void Inflate(float i_QuantityAirToAdd)
        {
            foreach(Wheel wheel in this.m_Wheels)
            {
                wheel.CurrentAirPressure += i_QuantityAirToAdd;
            }
        }

        // set the Manufacturer for each wheel
        public void SetWheelsManufacture(string i_ManufactureName)
        {
            for (int i = 0; i < this.m_Wheels.Length; i++)
            {
                this.m_Wheels[i].ManufactureName = i_ManufactureName;
            }
        }

        // set the PSI for each wheel
        public void SetWheelsPSI(float i_CurrentAirPressure)
        {
            for (int i = 0; i < this.m_Wheels.Length; i++)
            {
                this.m_Wheels[i].CurrentAirPressure = i_CurrentAirPressure;
            }
        }

        public override string ToString()
        {
            string o_VehicleDetails = string.Format("Vehicle Details:\nModel Name: {0}, License Number: {1}\n{2}\n{3}, \nEngine Details: \n{4} ",
                 m_ModelName, m_LicenseNumber, this.m_VehicleInfo.ToString(), this.m_Wheels[0].ToString(), this.m_Engine.ToString());

            return o_VehicleDetails;
        }
    }
}
