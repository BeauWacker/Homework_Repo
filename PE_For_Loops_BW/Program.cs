using System;

//Name: Beau Wacker
//Class: IGME 105
//Professor: Ann Warren
//Date: 10/6/2021
//Description: PE For Loops

namespace PE_For_Loops_BW
{
    class Program
    {
        static void Main(string[] args)
        {

            //Part 1 - print out three different number lists with int num.
            int num = 0;

            //while loop
            while (num <= 5)
            {
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine();  //lines for space between number lists
            num = 100;

            //do-while loop
            do
            {
                Console.WriteLine(num);
                num--;
            } while (num >= 95);

            Console.WriteLine(); //spacer
            num = 0;

            //for loop
            for (num = 0; num <= 25; num += 5)
            {
                Console.WriteLine(num);
            }




            //Part 2 - draw a box with width and height decided on user input
            Console.Write("\nEnter height: ");       //prompts for getting height and width
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(); //extra spacing for formatting
            
            //for loop to print out box with height and width
            for (int i = 0; i < height; i++)
            {
                Console.Write("0");
                    for (int j = 1; j < width; j++)
                    {
                        Console.Write("0");
                    }
                Console.WriteLine();
            }

            Console.WriteLine(); //spacer for formatting

            //for loop to print out box with space in the middle
            for (int i = 1; i <= height; i++) //first write the "0" at the beginning of the new row
            {
                Console.Write("0");

                    if (i == 1) //next, ifor the first and last rows, the entire row should be "0"s to make edges
                    {
                        for (int j = 1; j < width; j++)
                        {
                            Console.Write("0");
                        }
                    }
                    else if (i == height)
                    {
                        for (int j = 1; j < width; j++)
                        {
                            Console.Write("0");
                        }
                    }
                    else
                    {
                        for (int j = 2; j <= width; j++) //finally, only print "0" if it's the right edge
                        {
                            if (j == width)
                            {
                                Console.Write("0");
                            } else
                            {
                                Console.Write(" ");
                            }  
                        }
                    }

                Console.WriteLine();
            }
        }
    }
}
