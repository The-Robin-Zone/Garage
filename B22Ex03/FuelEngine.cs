﻿using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_FuelType
    {
        Soler = 0,
        Octane95 = 1,
        Octane96 = 2,
        Octane98 = 3
    }

    internal class FuelEngine : Engine
    {
        private e_FuelType m_FuelType;

        // Gas engine constructor
        internal FuelEngine() : base()
        {
        }

        public e_FuelType FuelType
        {
            get
            {
                return this.m_FuelType;
            }

            set
            {
                this.m_FuelType = value;
            }
        }

        public void Refuel(float i_NbrFuelToAdd)
        {
            if (i_NbrFuelToAdd < 0 || (this.m_CurrentEnergy + i_NbrFuelToAdd > base.m_MaxEnergy))
            {
                throw new ValueOutOfRangeException(base.m_MaxEnergy - this.CurrentEnergy, 0);
            }
            else
            {
                base.m_CurrentEnergy += i_NbrFuelToAdd;
            }
        } 

        public override string ToString()
        {
            return string.Format(base.ToString() + ", Fuel type: {0}, Max Fuel: {1} liters, Current Fuel: {2} liters ",
                m_FuelType.ToString(), base.MaxEnergy, base.CurrentEnergy);
        }
    }
}
