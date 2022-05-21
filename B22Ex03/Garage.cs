using System;
using System.Collections.Generic;
using System.Text;


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

        // Display list of license number with filter
        public StringBuilder AllLicensedNumber()
        {
            StringBuilder o_AllVehiculeInGarage = new StringBuilder();
            foreach (string licensedNumber in this.m_Garage.Keys)
            {
                o_AllVehiculeInGarage.AppendLine(licensedNumber);
            }
            return o_AllVehiculeInGarage;
        }

        // Display list of license number with filter
        public StringBuilder AllLicensedNumberByFilter(e_StatusVehicle i_vehiculeStatus)
        {
            StringBuilder o_AllLicensedNumberByFilter = new StringBuilder();
            foreach (string licensedNumber in this.m_Garage.Keys)
            {
                if (this.m_Garage[licensedNumber].VehicleInfo.StatusVehicule == i_vehiculeStatus)
                {
                    o_AllLicensedNumberByFilter.AppendLine(licensedNumber);
                }
            }
            return o_AllLicensedNumberByFilter;
        }

        // Change status of vehicle to the updated one
        public void UpdateStatus(string i_LicenseNumber, e_StatusVehicle i_NewStatus)
        {
            Vehicle currentVehicule = this.m_Garage[i_LicenseNumber];
            currentVehicule.VehicleInfo.UpdateStatusVehicule(i_NewStatus);
        }

        // Add air to wheels
        public void InflateWheels(string i_LicenseNumber)
        {

            this.m_Garage[i_LicenseNumber].Inflate();
        }

        // Add fuel to FuelEngine
        public void Refuel(string i_LicensedNumber, e_FuelType i_FuelType, float i_AmountToFill)
        {

            if (this.m_Garage[i_LicensedNumber].Engine is FuelEngine)
            {
                (this.m_Garage[i_LicensedNumber].Engine as FuelEngine).Refuel(i_FuelType, i_AmountToFill);
            }
            else
            {
                throw new ArgumentException("Try to add energy to the wrong type of vehicle");
            }

        }

        // Ass Electricity to ElectricEngine
        public void Recharge(string i_LicensedNumber, float i_TimeToRecharge)
        {
            
            if (this.m_Garage[i_LicensedNumber].Engine is ElectricEngine)
            {
                (this.m_Garage[i_LicensedNumber].Engine as ElectricEngine).Recharge(i_TimeToRecharge);
            }
            else
            {
                throw new ArgumentException("Try to add energy to the wrong type of vehicle");
            }
        }
    }
}
