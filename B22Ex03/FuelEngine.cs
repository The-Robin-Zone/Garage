﻿using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    enum e_FuelType
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
        internal FuelEngine(e_FuelType i_FuelType, float i_MaxEnergy, float i_CurrentEnergy) : base(i_MaxEnergy, i_CurrentEnergy)
        {
            this.m_FuelType = i_FuelType;

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
    }
}