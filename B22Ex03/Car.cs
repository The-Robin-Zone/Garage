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
        Two = 1,
        Three = 2,
        Foor = 3,
        Five = 4
    }

    public class Car : Vehicle
    {
        private const int c_MaxAirPressure = 29;
        private const int c_NumberWheels = 4;
        private const float c_MaxFuelTank = 38F;
        private const float c_MaxBatteryLife = 198F;
        private const e_FuelType c_FuelType = e_FuelType.Octane95;
        private e_ColorVehicle m_colorVehicle;
        private e_NumberOfDoors m_NumberOfDoors;

        public Car(string i_LicenseNumber, Engine i_Engine ) : base(i_LicenseNumber, i_Engine, c_MaxAirPressure, c_NumberWheels, c_MaxFuelTank, c_MaxBatteryLife, c_FuelType)
        {  
        }

        public e_ColorVehicle ColorVehicle
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

        public e_NumberOfDoors NumberOfDoors
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

        public override string ToString()
        {
            return string.Format(base.ToString() + "\nCar Details: \nVehicle Color: {0}, Number of doors: {1} ",
                m_colorVehicle.ToString(), m_NumberOfDoors.ToString());
        }
    }
}
