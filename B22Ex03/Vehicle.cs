using System;
using System.Collections.Generic;


namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Vehicle
    {
        protected string m_ModelName;
        protected string m_LicenseNumber;
        protected float m_RemainingEnergy;
        protected VehicleInfo m_VehicleInfo;
        protected Wheel[] m_Wheels;
        protected Engine m_Engine;

        public Vehicle(string i_LicenseNumber, Engine i_engine, float i_MaxAirPressure, int i_NumberWheels, float c_MaxFuelTank, float? c_MaxBatteryLife)
        {
            this.m_LicenseNumber = i_LicenseNumber;
            this.m_VehicleInfo = new VehicleInfo();
            this.m_Wheels = new Wheel[i_NumberWheels];
            this.m_Engine = i_engine;
            this.m_VehicleInfo = new VehicleInfo();
            for (int i = 0; i < i_NumberWheels; i++)
            {
                this.m_Wheels[i] = new Wheel(i_MaxAirPressure);
            }
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
                return this.m_LicenseNumber;
            }
            set
            {
                this.m_LicenseNumber = value;
            }
        }

        float RemainingEnergy
        {
            get
            {
                SetRemainingEnergy();
                return this.m_RemainingEnergy;
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

        public Engine TypeEngine
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

        // Determine the remaining energy
        public void SetRemainingEnergy()
        {
            this.m_RemainingEnergy = this.m_Engine.CurrentEnergy / this.m_Engine.MaxEnergy * 100;
        }

        // Inflate all tires
        public void Inflate(float i_NbrAirToAdd)
        {
            foreach(Wheel wheel in this.m_Wheels)
            {
                wheel.CurrentAirPressure += i_NbrAirToAdd;
            }
        }

        // Give the info about each wheels
        public void SetWheelsInfo(string i_ManufactureName, float i_CurrentAirPressure)
        {
            for (int i = 0; i < this.m_Wheels.Length; i++)
            {
                this.m_Wheels[i].ManufactureName = i_ManufactureName;
                this.m_Wheels[i].CurrentAirPressure = i_CurrentAirPressure;
            }
        }

        public override string ToString()
        {
            string o_VehicleDetails = string.Format("Vehicle Detail:\n Model Name: {0}, License Number: {1} Remaining Energy: {2} {3} {4} ",
                 m_ModelName, m_LicenseNumber, m_RemainingEnergy, this.m_VehicleInfo.ToString(), this.m_Wheels[0].ToString(), this.m_Engine.ToString());

            return o_VehicleDetails;
        }
    }
}
