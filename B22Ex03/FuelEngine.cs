using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_FuelType
    {
        Soler = 1,
        Octane95 = 2,
        Octane96 = 3,
        Octane98 = 4
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

        public void Refuel(e_FuelType i_FuelType, float i_NbrFuelToAdd)
        {
            try
            {
                if (this.m_FuelType != i_FuelType)
                {
                    throw new ArgumentException(string.Format("Try to refuel with {0}, when the right type is {1}", i_FuelType.ToString(), this.m_FuelType.ToString()));
                }
                if (i_NbrFuelToAdd < 0 || (this.m_CurrentEnergy + i_NbrFuelToAdd > base.m_MaxEnergy))
                {
                    throw new ValueOutOfRangeException(0, base.m_MaxEnergy - this.CurrentEnergy);
                }
                else
                {
                    CurrentEnergy += i_NbrFuelToAdd;
                }
            }
            catch (ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
            catch (ValueOutOfRangeException valueOutOfRangeException)
            {
                Console.WriteLine(valueOutOfRangeException.Message);
            }
        } 

        public override string ToString()
        {
            return string.Format(base.ToString() + ", Fuel type: {0}, Max Fuel: {1} liters, Current Fuel: {2} liters ",
                m_FuelType.ToString(), base.MaxEnergy, base.CurrentEnergy);
        }
    }
}
