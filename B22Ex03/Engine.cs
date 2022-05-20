using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_EngineType
    {
        Fuel,
        Electric
    }

    public class Engine
    {
        protected float m_MaxEnergy;
        protected float m_CurrentEnergy;
        protected float m_EnergyLeftPrcentage;

        public Engine()
        {
        }

        public float MaxEnergy
        {
            get
            {
                return this.m_MaxEnergy;
            }

        }

        public float CurrentEnergy
        {
            get
            {
                return this.m_CurrentEnergy;
            }

            set
            {
                this.m_CurrentEnergy = value;
                this.m_EnergyLeftPrcentage = this.m_CurrentEnergy / this.m_MaxEnergy * 100;
            }
        }

        public float EnergyLeftPrcentage
        {
            get
            {
                return this.m_EnergyLeftPrcentage;
            }
            
        }

        public override string ToString()
        {
            return string.Format("Energy Left Prcentage: {0}", m_EnergyLeftPrcentage);
        }
    }
}
