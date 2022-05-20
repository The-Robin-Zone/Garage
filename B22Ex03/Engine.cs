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
            }
        }

        public override string ToString()
        {
            string EngineDetails = string.Format("Engine:\nMax Energy: {0} Current Energy: {1}, Energy Left Prcentage: {2}",
                m_MaxEnergy, m_CurrentEnergy, m_EnergyLeftPrcentage);

            return EngineDetails;
        }
    }
}