using System;
namespace B22Ex03Shaked203943253Fanny337957633
{

    internal class ElectricEngine : Engine
    {

        // Electric engine constructor
        internal ElectricEngine() : base()
        {
        }

        public void Recharge(float i_NbrHoursToAdd)
        {
            if (i_NbrHoursToAdd < 0 || (this.m_CurrentEnergy + i_NbrHoursToAdd > base.m_MaxEnergy))
            {
                throw new ValueOutOfRangeException(base.m_MaxEnergy - this.CurrentEnergy, 0);
            }
            else
            {
                base.m_CurrentEnergy += i_NbrHoursToAdd;
            }
        }

        public override string ToString()
        {

            return string.Format(base.ToString() + ", Max Battery: {0} hours, Current Battery: {1} hours ", base.MaxEnergy, base.CurrentEnergy);
        }

    }
}
