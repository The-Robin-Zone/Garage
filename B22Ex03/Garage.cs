using System;
using System.Collections.Generic;

namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Garage
    {
        private Dictionary<string, Vehicle> m_Garage;
        private List<SupportedVehicles> m_TypeOfVehicleHandle;
        public Garage()
        {
            this.m_Garage = new Dictionary<string, Vehicle>();
            this.m_TypeOfVehicleHandle = new List<SupportedVehicles>();
            typeOfSupportedVehicle();
        }

        public Dictionary<string, Vehicle> VehiclesInGarage
        {
            get
            {
                return this.m_Garage;
            }
        }

        public List<SupportedVehicles> TypeOfVehicleHandle
        {
            get
            {
                return this.m_TypeOfVehicleHandle;
            }
        }

        private void typeOfSupportedVehicle()
        {
            m_TypeOfVehicleHandle.Add(new SupportedVehicles(e_VehicleType.Motorcycle, e_EngineType.Fuel));
            m_TypeOfVehicleHandle.Add(new SupportedVehicles(e_VehicleType.Motorcycle,  e_EngineType.Electric));
            m_TypeOfVehicleHandle.Add(new SupportedVehicles(e_VehicleType.Car, e_EngineType.Fuel));
            m_TypeOfVehicleHandle.Add(new SupportedVehicles(e_VehicleType.Car, e_EngineType.Electric));
            m_TypeOfVehicleHandle.Add(new SupportedVehicles(e_VehicleType.Truck, e_EngineType.Fuel));
        }

        //Insert new vehicule to dictionnary,
        public void AddNewVehicule(string i_LicensedNumber, Vehicle i_Vehicle)
        {
            this.m_Garage.Add(i_LicensedNumber, i_Vehicle);
        }

        // Search if the license exist in the garage
        public bool IsVehiculeInGarage(string i_licensedNumber)
        {
            bool o_IsVehiculeInGarage = this.m_Garage.ContainsKey(i_licensedNumber);
            return o_IsVehiculeInGarage;
        }

        // Display list of license number
        public string AllVehiculesInGarage(e_StatusVehicle i_vehiculeStatus)
        {
            string o_AllVehiculeInGarage = string.Empty;
            foreach (string licensedNumber in this.m_Garage.Keys)
            {
                if (this.m_Garage[licensedNumber].VehicleInfo.StatusVehicule == i_vehiculeStatus)
                {

                }
                o_AllVehiculeInGarage += String.Format("{0}\n", licensedNumber);
            }
            return o_AllVehiculeInGarage;
        }

        public void UpdateStatus(string i_LicenseNumber, int i_NewStatus)
        {
            Vehicle currentVehicule = this.m_Garage[i_LicenseNumber];
            e_StatusVehicle newStatusVehicle = currentVehicule.VehicleInfo.UpdateStatusVehicule(i_NewStatus);
            currentVehicule.VehicleInfo.StatusVehicule = newStatusVehicle;
        }

        public void InflateWheels(string i_LicenseNumber, float i_NbrAirToAdd)
        {
            this.m_Garage[i_LicenseNumber].Inflate(i_NbrAirToAdd);
        }

        public void Refuel(string i_LicensedNumber, e_FuelType i_FuelType, float i_AmountToFill)
        {
            //this.m_Garage[i_LicenseNumber].Engin
        }

        // Recharge(string i_LicensedNumber, umber of minutes to recharge)



    }
}
