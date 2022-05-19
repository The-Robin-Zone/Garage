using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Engine test1 = new ElectricEngine(10,5);
            Engine test2 = new FuelEngine((e_FuelType)1, 10, 5);
        }
    }
}
