using System;

//Static Helper Methods
//Beau Wacker
//Program that lets the user compare numbers, get a secret code, or both
// 10/1 - Input ToDo for GetPromptedInput for name, a, and b
// 10/4 - Created CompareNumbers method
// 10/4 - Created GetSecretCode method
// 10/4 - Created PrintAllInfo method and implemented all methods into the choices switch

namespace Static_Helper_Methods_BW
{
    class Program
    {
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // LEAVE THESE HELPER METHODS ALONE!
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // Helper written by Prof. Mesh
        // Check if one number is a factor of another
        public static bool IsFactorOf(int factor, int number)
        {
            // Return true if "factor" is smaller than "number"
            // and is evenly divisible into "number"
            return factor < number && number % factor == 0;
        }
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
            // Switch back to white and then return response.
            Console.ForegroundColor = ConsoleColor.White;
            return response;
        }

        //CheckNumbers helper method
        public static void CheckNumbers(int a, int b)
        {
            if (IsFactorOf(a, b))
                Console.WriteLine(a + " & " + b + " are awesome numbers!");
            else if
                (IsFactorOf(b, a))
                Console.WriteLine(a + " & " + b + " are awesome numbers!");
            else
                Console.WriteLine(a + " & " + b + " are okay I guess");
            return;
        }

        //GetSecretCode helper method
        public static int GetSecretCode(string name, int a, int b)
        {
            int secretCode = (name[0] * ((a + b)^b));
            return secretCode;
        }
        
        //PrintAllInfo helper method
        public static void PrintAllInfo(string name, int a, int b)
        {
            Console.WriteLine("Your name is " + name.ToUpper() +
                "\nYour favorite numbers are " + a + " & " + b +
                ",\nand your secret code is " + GetSecretCode(name, a, b) + ".");
        }

        static void Main(string[] args)
        {
            // Setup variables
            string name = "";
            int a = 0;
            int b = 0;
            int choice = 0;
            // Get values for name, a, and b using GetPromptedInput and parsing if needed.
            // TODO: ADD YOUR USER INPUT CODE HERE
            name = GetPromptedInput("What is your name?");
            a = Convert.ToInt32(GetPromptedInput("Enter a whole number: "));
            b = Convert.ToInt32(GetPromptedInput("Enter another whole number: "));

            // Reformat the name
            name = name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower();
            // Print the menu
            Console.WriteLine("\nHello {0}, what would you like to do?\n" +
            "\t1 - Compare numbers\n" +
            "\t2 - Get my secret code\n" +
            "\t3 - Output all info",
            name);
            choice = int.Parse(GetPromptedInput(">"));
            Console.WriteLine();
            // Figure out what to do and do it
            switch (choice)
            {
                // Check numbers
                case 1:
                    CheckNumbers(a, b);
                    break;
                // Get secret code
                case 2:
                    Console.WriteLine("Your secret code is " + GetSecretCode(name, a, b));
                    break;
                // Output all info
                case 3:
                    PrintAllInfo(name, a, b);
                    CheckNumbers(a, b);
                    break;
                // Say goodbye for invalid choices
                default:
                    Console.WriteLine("That wasn't a valid choice. Goodbye.");
                    break;
            }
        }
    }
}
