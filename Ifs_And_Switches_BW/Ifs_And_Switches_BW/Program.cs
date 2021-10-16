using System;

//Ifs & Switches
//Beau Wacker
//10/1/2021 - Outlined assignment to-dos with comments
namespace Ifs_And_Switches_BW
{
    class Program
    {
        static void Main(string[] args)
        {
            //if/else
            //What is 4 * 8? (32)
            //That's correct!
            //or
            //That's incorrect!
            Console.Write("What is 4 * 8? ");
            if (Convert.ToInt32(Console.ReadLine()) == 32)
            {
                Console.Write("That's correct!");
            }
            else
            {
                Console.Write("That's incorrect!");
            }

            //if/else if/else
            //List these numbers from least to greatest: 29, 3, 102
            //1: 1
            //2: 2
            //3: 3
            //That's correct!
            //or
            //That's backwards!
            //or
            //That's completely incorrect!
            Console.WriteLine("\n\nList three whole numbers from greatest to least:");
            Console.Write("1. ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. ");
            int c = Convert.ToInt32(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.Write("That's correct!");
            } else if (a == b && b == c)
            {
                Console.Write("Those are all equal!");
            } else
            {
                Console.Write("That's completely incorrect!");
            }


            //switch
            //Switches are best for...
            //        a. wrong
            //        b. correct
            //        c. wrong
            //        d. wrong
            Console.WriteLine("\n\nWhich continent is the largest?" +
                              "\n\t\tA) North America" +
                              "\n\t\tB) Asia" +
                              "\n\t\tC) Africa" +
                              "\n\t\tD) Europe" +
                              "\n(Type in A, B, or C)");
            string answer = Console.ReadLine().ToUpper();

            switch (answer)
            {
                case "B":
                    Console.Write("Correct!");
                    break;
                case "A":  
                case "C":   
                case "D":
                    Console.Write("Incorrect! The continent of \"Asia\" is 17.21 millions square miles!");
                    break;
                default:
                    Console.Write("That isn't an answer!");
                    break;
            }


        }
    }
}
