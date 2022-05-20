using System;
namespace B22Ex03Shaked203943253Fanny337957633
{

    internal class ElectricEngine : Engine
    {

        // Electric engine constructor
        internal ElectricEngine(float i_MaxEnergy) : base(i_MaxEnergy)
        {

        }

        public void Recharge(float i_NbrHoursToAdd)
        {
            base.m_CurrentEnergy += i_NbrHoursToAdd;
        }

    }
}
