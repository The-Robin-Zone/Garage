using System;
namespace B22Ex03Shaked203943253Fanny337957633
{

    internal class ElectricEngine : Engine
    {

        // Electric engine constructor
        internal ElectricEngine() : base()
        {
        }

        // Recharge vehicle if the 
        public void Recharge(float i_NbrOfMinutesToAdd)
        {
            if (i_NbrOfMinutesToAdd < 0 || (this.m_CurrentEnergy + i_NbrOfMinutesToAdd > base.m_MaxEnergy))
            {
                string message = "Value is out of range, the range is {0} to {1} minutes";
                throw new ValueOutOfRangeException(0, base.m_MaxEnergy - this.CurrentEnergy, message);
            }
            else
            {
                CurrentEnergy += i_NbrOfMinutesToAdd;
            }
        }

        public override string ToString()
        {

            return string.Format(base.ToString() + ", Max Battery: {0} hours, Current Battery: {1} hours ", base.MaxEnergy / 60, (base.CurrentEnergy / 60).ToString("0.00"));
        }

    }
}
