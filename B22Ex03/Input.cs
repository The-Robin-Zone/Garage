using System;
namespace B22Ex03Shaked203943253Fanny337957633
{
    public class Input
    {
        public static int GetHomePageChoice()
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
                    if (o_UserInput <= 7 && o_UserInput != 0)
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
    }
}
