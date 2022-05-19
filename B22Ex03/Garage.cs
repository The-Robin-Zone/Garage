using System;
using System.Collections.Generic;

namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Garage
    {
        private Dictionary<string, Vehicle> m_Garage;
        public Garage()
        {
            this.m_Garage = new Dictionary<string, Vehicle>();
        }

        public Dictionary<string, Vehicle> GarageList
        {
            get
            {
                return this.m_Garage;
            }
        }

        //Insert new vehicule to dictionnary,
        public void AddNewVehicule()
        {

        }

        // Search if the license exist in the garage
        public bool IsVehiculeInGarage(string i_licensedNumber)
        {
            bool o_IsVehiculeInGarage = this.m_Garage.ContainsKey(i_licensedNumber);
            return o_IsVehiculeInGarage;
        }

        // Display list of license number
        public string AllVehiculesInGarage(string vehiculeStatus)
        {
            string o_AllVehiculeInGarage = string.Empty;
            foreach (string licensedNumber in this.m_Garage.Keys)
            {
                o_AllVehiculeInGarage += String.Format(" ", licensedNumber);
            }
            return o_AllVehiculeInGarage;
        }

        public void UpdateStatus(string i_LicenseNumber, int i_NewStatus)
        {
            Vehicle currentVehicule = this.m_Garage[i_LicenseNumber];
            e_StatusVehicle newStatusVehicle = currentVehicule.VehicleInfo.UpdateStatusVehicule(i_NewStatus);
            currentVehicule.VehicleInfo.StatusVehicule = newStatusVehicle;
                    
        }

        //Inflate tires(string i_LicenseNumber)

        // Refuel(string i_LicensedNumber, Fuel Type, ampount to fill)

        // Recharge(string i_LicensedNumber, umber of minutes to recharge)



    }
}
