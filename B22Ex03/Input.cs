using System;
namespace B22Ex03
{
    public class Input
    {

        public static int GetHomePageChoice()
        {
            string UserInput = string.Empty;
            bool IsInputIllegal = true;
            int o_UserInput = 0;

            while (IsInputIllegal)
            {
                UserInput = Console.ReadLine();
                if (UserInput.Length == 1 && (int.TryParse(UserInput, out o_UserInput)))
                {
                    IsInputIllegal = false;
                }
            }
            return o_UserInput;
        }
    }
}
