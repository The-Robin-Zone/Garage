using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_EngineType
    {
        Fuel,
        Electric
    }

    public abstract class Engine
    {
        protected readonly float m_MaxEnergy;
        protected float m_CurrentEnergy;

        public Engine(float i_MaxEnergy, float i_CurrentEnergy)
        {
            if (i_MaxEnergy <= 0 || i_CurrentEnergy < 0)
            {
                // Throw exception
            }

            if (i_MaxEnergy < i_CurrentEnergy)
            {
                // Throw exception
            }

            this.m_MaxEnergy = i_MaxEnergy;
            this.m_CurrentEnergy = i_CurrentEnergy;
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
    }
}