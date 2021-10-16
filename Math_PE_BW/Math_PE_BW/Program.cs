using System;
/*
 Beau Wacker
 PE_Math Assignment
 9/20 - created name and height variables
      - implemented name equations
      - implemented area and circumference equations
 */
namespace Math_PE_BW
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user for first name, last name, and height and stores the input
            Console.Write("Enter your first name: ");
            string fName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string lName = Console.ReadLine();
            Console.Write("Enter your height (in inches): ");
            string height = Console.ReadLine();

            //Calculates which name is longer and the difference in length between them and states the results
            Console.WriteLine("Your longer name is " + (Math.Max(fName.Length, lName.Length)) + " letters long.");
            Console.WriteLine("There's a " + Math.Abs((fName.Length) - (lName.Length)) + 
                             " letter difference between the lengths of your first name and last name");

            //Calculates area and circumference of circle using height as diamater and states the results
            Console.WriteLine("You would fit in a circle with an area of " + 
                             Math.Round((Math.PI * (Math.Pow((Convert.ToDouble(height)/2), 2.0))),2) + 
                             " square inches \nand a circumference of " + 
                             Math.Round((2 * Math.PI * (Convert.ToDouble(height)/2)),2) + 
                             " inches.");
        }
    }
}
