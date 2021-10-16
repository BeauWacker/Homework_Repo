using System;

//PE While Loops
//Beau Wacker
//Program that does equations with user input values
// 10/4 - pasted pre-maded code into program
//      - created GetValidIntegerInput method to return an integer <100 and >0

namespace PE_While_Loops_BW
{
    class Program
    {
        // Input helper written by Prof. Mesh
        public static string GetPromptedInput(string prompt)
        {
            // Always print in white
            Console.ForegroundColor = ConsoleColor.White;
            // Print the prompt
            Console.Write(prompt + " ");
            // Switch color and get user input (trim too)
            Console.ForegroundColor = ConsoleColor.Cyan;
            string response = Console.ReadLine().Trim();
            // Switch back to white and then return the response.
            Console.ForegroundColor = ConsoleColor.White;
            return response;
        }

        //GetValidIntegerInput helper method
        public static int GetValidIntegerInput(string prompt, int min, int max)
        {
            int num = Convert.ToInt32(GetPromptedInput(prompt));
            while (num < min || num > max)
            {
                Console.Write("Your number must be between 0 and 100, please enter a different number > ");
                // Switch color and get user input (trim too)
                Console.ForegroundColor = ConsoleColor.Cyan;
                num = Convert.ToInt32(Console.ReadLine().Trim());
                // Switch back to white and then return the response.
                Console.ForegroundColor = ConsoleColor.White;
            }
            return num;
        }

        static void Main(string[] args)
        {
            // Use a do-while so that the menu is
            // always shown at least once
            bool gameActive = true;
            do
            {
                // Prompt for and get their choice
                Console.WriteLine("\n\nWhat do you want to do?\n" +
                "\tDo some MATH\n" +
                "\tQUIT\n");
                string choice = GetPromptedInput(">").ToUpper();
                // Do something based on the user choice
                switch (choice)
                {
                    case "MATH":
                        Console.WriteLine("Enter positive numbers < 100 until the total is above 100:");
                        int total = 0;
                        while (total < 100)
                        {
                            total += GetValidIntegerInput(String.Format("Total: {0} > ", total), 0, 100);
                        }
                        Console.Write("Final Total: {0}", total);
                        break;
                    case "QUIT":
                        // end the game by changing the LCV to false
                        gameActive = false;
                        break;
                    default:
                        Console.WriteLine("That wasn't an option...");
                        break;
                }
            }
            while (gameActive);
        }
    }
}
