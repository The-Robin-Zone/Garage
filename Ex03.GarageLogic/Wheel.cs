using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Wheel
    {
        private readonly string r_ManufactureName;
        private float m_CurrentAirPressure;
        private readonly float r_MaxAirPressure;


        public Wheel(string i_ManufactureName, float i_CurrentAirPressure, float i_MaxAirPressure)
        {
            if (i_CurrentAirPressure < 0 || i_MaxAirPressure <= 0)
            {
                // Throw exception
            }

            if (i_CurrentAirPressure > i_MaxAirPressure)
            {
                // Throw exception
            }

            this.r_ManufactureName = i_ManufactureName;
            this.m_CurrentAirPressure = i_CurrentAirPressure;
            this.r_MaxAirPressure = i_MaxAirPressure;
        }

        public string ManufactureName
        {
            get
            {
                return this.r_ManufactureName;
            }
        }

        public float CurrentAirPressure
        {
            get
            {
                return this.m_CurrentAirPressure;
            }

            set
            {
                this.m_CurrentAirPressure = value;
            }
        }

        public float MaxAirPressure
        {
            get
            {
                return this.r_MaxAirPressure;
            }
        }

        public void Inflate()
        {
            this.m_CurrentAirPressure = this.r_MaxAirPressure;
        }
    }
}
