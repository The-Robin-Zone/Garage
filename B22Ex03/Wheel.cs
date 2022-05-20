using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Wheel
    {
        private string m_ManufactureName;
        private float m_CurrentAirPressure;
        private readonly float r_MaxAirPressure;


        public Wheel(float i_MaxAirPressure)
        {
            //if (i_CurrentAirPressure < 0 || i_MaxAirPressure <= 0)
            //{
            //    // Throw exception
            //}

            //if (i_CurrentAirPressure > i_MaxAirPressure)
            //{
            //    // Throw exception
            //}

            this.r_MaxAirPressure = i_MaxAirPressure;
        }

        public string ManufactureName
        {
            get
            {
                return this.m_ManufactureName;
            }
            set
            {
                this.m_ManufactureName = value;
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
                if (value < 0 || (value > r_MaxAirPressure))
                {

                    throw new ValueOutOfRangeException(r_MaxAirPressure, 0);
                }
                else
                {
                    this.m_CurrentAirPressure = value;
                }
                
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

        public override string ToString()
        {
            string WheelDetails = string.Format("Wheel Detail:\nManufacture Name: {0}, Current Air Pressure: {1}, Max Air Pressure: {2}",
                m_ManufactureName, m_CurrentAirPressure, r_MaxAirPressure);

            return WheelDetails;
        }
    }
}
