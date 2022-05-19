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
        private readonly e_ColorVehicle m_colorVehicle;
        private readonly e_NumberOfDoors r_NumberOfDoors;
        private readonly Engine m_TypeEnergy;

        public Car(string i_ModelName, string i_LicenseNumber, float i_RemainingEnergy,
            string i_Manufacturer, float i_CurrenttAirPressure,
            int i_colorVehicle, int i_NumberOfDoors, Engine i_TypeEnergy)
            : base(i_ModelName, i_LicenseNumber, i_RemainingEnergy, i_Manufacturer, i_CurrenttAirPressure, c_MaxAirPressure)
        {
            this.m_colorVehicle = (e_ColorVehicle)i_colorVehicle;
            this.r_NumberOfDoors = (e_NumberOfDoors)i_NumberOfDoors;
            this.m_TypeEnergy = i_TypeEnergy;
        }

        e_ColorVehicle ColorVehicle
        {
            get
            {
                return this.m_colorVehicle;
            }
        }

        e_NumberOfDoors NumberOfDoors
        {
            get
            {
                return this.r_NumberOfDoors;
            }
        }

        Engine TypeEnergy
        {
            get
            {
                return this.m_TypeEnergy;
            }
        }
    }
}
