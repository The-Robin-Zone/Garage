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
        // User will need to add the type of new vehicule 
        //public insert()

        // Search if the license exist in the garage
        //public search

        // Display list of license number
        // public

        // Change vehicule status

        //Inflate tires(string i_LicenseNumber)

        // Refuel(string i_LicensedNumber, Fuel Type, ampount to fill)

        // Recharge(string i_LicensedNumber, umber of minutes to recharge)



    }
}
