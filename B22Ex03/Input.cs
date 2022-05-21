using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Input
    {
        public static int GetUserOption(int i_MaxValue)
        {
            string UserInput = string.Empty;
            int o_UserInput = 0;
            bool isInputIllegal = true;
            bool isInputInt;

            while (isInputIllegal)
            {
                UserInput = Console.ReadLine();
                isInputInt = int.TryParse(UserInput, out o_UserInput);

                if (UserInput.Length == 1 && isInputInt)
                {
                    if (o_UserInput <= i_MaxValue && o_UserInput != 0)
                    {
                        isInputIllegal = false;
                    }
                }

                if (isInputIllegal)
                {
                    Output.InvalidInputPrompt();
                }
            }
            return o_UserInput;
        }

        public static e_LicenseType GetUserLicenseType()
        {
            int userInput;

            string[] LicenseTypeArray = Enum.GetNames(typeof(e_LicenseType));

            for (int i = 0; i < LicenseTypeArray.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + LicenseTypeArray[i]);
            }

            userInput = GetUserOption(LicenseTypeArray.Length);

            return (e_LicenseType)(userInput);
        }

        public static int GetUserInt()
        {
            string UserInput = string.Empty;
            int o_UserInput = 0;
            bool isInputIllegal = true;
            bool isInputInt;

            while (isInputIllegal)
            {
                UserInput = Console.ReadLine();
                isInputInt = int.TryParse(UserInput, out o_UserInput);

                if (isInputInt)
                {
                    isInputIllegal = false;
                }

                if (isInputIllegal)
                {
                    Output.InvalidInputPrompt();
                }
            }
            return o_UserInput;
        }

        public static e_ColorVehicle GetUserVehicleColor()
        {
            int userInput;

            string[] ColorArray = Enum.GetNames(typeof(e_ColorVehicle));

            for (int i = 0; i < ColorArray.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + ColorArray[i]);
            }

            userInput = GetUserOption(ColorArray.Length);

            return (e_ColorVehicle)(userInput);
        }

        public static e_NumberOfDoors GetUserNumberOfDoors()
        {
            int userInput;

            string[] PossibleNumOfDoorsArray = Enum.GetNames(typeof(e_NumberOfDoors));

            for (int i = 0; i < PossibleNumOfDoorsArray.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + PossibleNumOfDoorsArray[i]);
            }

            userInput = GetUserOption(PossibleNumOfDoorsArray.Length);

            return (e_NumberOfDoors)(userInput);
        }

        public static bool GetUserBool()
        {
            int userInput;
            bool o_userOutput;

            Console.WriteLine("1) true");
            Console.WriteLine("2) false");

            userInput = GetUserOption(2);

            if (userInput == 1)
            {
                o_userOutput = true;
            }
            else
            {
                o_userOutput = false;
            }

            return o_userOutput;
        }

        public static float GetUserFloat()
        {
            string UserInput = string.Empty;
            float o_UserInput = 0;
            bool isInputIllegal = true;
            bool isInputInt;

            while (isInputIllegal)
            {
                UserInput = Console.ReadLine();
                isInputInt = float.TryParse(UserInput, out o_UserInput);

                if (isInputInt)
                {
                    isInputIllegal = false;
                }

                if (isInputIllegal)
                {
                    Output.InvalidInputPrompt();
                }
            }
            return o_UserInput;
        }

        public static e_FuelType GetUserFuelType()
        {
            int userInput;

            string[] FuelTypeArray = Enum.GetNames(typeof(e_FuelType));

            for (int i = 0; i < FuelTypeArray.Length; i++)
            {
                Console.WriteLine((i + 1) + ") " + FuelTypeArray[i]);
            }

            userInput = GetUserOption(FuelTypeArray.Length);

            return (e_FuelType)(userInput);
        }
    }
}
