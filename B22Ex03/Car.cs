using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public enum e_ColorVehicle
    {
        Red = 1,
        White = 2,
        Green = 3,
        Blue = 4
    }

    public enum e_NumberOfDoors
    {
        Two = 2,
        Three = 3,
        Foor = 4,
        Five = 5
    }

    public class Car : Vehicle
    {
        private const int c_MaxAirPressure = 29;
        private e_ColorVehicle m_colorVehicle;
        private e_NumberOfDoors m_NumberOfDoors;
        private Engine m_TypeEnergy;

        public Car(string i_LicenseNumber, int i_NumberWheels)
            : base(i_LicenseNumber, c_MaxAirPressure)
        {
            
        }

        e_ColorVehicle ColorVehicle
        {
            get
            {
                return this.m_colorVehicle;
            }
            set
            {
                this.m_colorVehicle = value;
            }
        }

        e_NumberOfDoors NumberOfDoors
        {
            get
            {
                return this.m_NumberOfDoors;
            }
            set
            {
                this.m_NumberOfDoors = value;
            }
        }

        Engine TypeEnergy
        {
            get
            {
                return this.m_TypeEnergy;
            }
            set
            {
                this.m_TypeEnergy = value;
            }
        }
    }
}
