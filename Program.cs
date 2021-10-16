using System;
//Beau Wacker
//IGME 105
//Ann Warren
//Player Choice
//  10/14/21

namespace HW2_PlayerChoice_BW
{
    class Program
    {
        //Player choice method
        //Takes user input and generates number for choice
        public static int playerChoice (string choiceOne, string choiceTwo, string choiceThree)     
        {
            int choiceNum = 0;
            string choice = Console.ReadLine().ToUpper().Trim();

            if (choice == choiceOne)
            {
                choiceNum = 1;
            } else if (choice == choiceTwo)
            {
                choiceNum = 2;
            } else if (choice == choiceThree)
            {
                if (choiceThree == "NULL")
                {
                    choiceNum = 0;
                }
                else
                {
                    choiceNum = 3;
                }
            }

            return choiceNum;
        }

        //Choice Results method
        //Takes number from playerChoice and generates response
        public static string choiceResponse (int choiceNum, string resultOne, string resultTwo, string resultThree)     
        {
            string response = "";
            switch (choiceNum)
            {
                case 1:
                    response = resultOne;
                    break;
                case 2:
                    response = resultTwo;
                    break;
                case 3:
                    response = resultThree;
                    break;
            }

            return response;
        }

        //Ending method
        //Calculates ending based on player's stats
        public static string ending (int reputation, int wealth, int strength)
        {
            string ending = "";
            if (strength < 1)
            {
                ending = "\nThe Invaders attack and you are too weak to fight them off! You die!";      //Death ending
            } else if (reputation >= 3)
            {
                ending = "\nBecause of your REPUTATION, the Invaders recognize that you're a hero!" +       //Knight ending
                         "\nThey decide that the fight is not worth it and flee!" +
                         "\nWith your heroic reputation, you recruit the citizens of the city to fight back, " +
                         "\nand the invaders are driven away!" +
                         "\nThe King of Capitol City thanks you, and grants you knighthood!" +
                         "\nGame over!";
            } else if (strength >= 2 && wealth >= 2)
            {
                ending = "\nThe Invaders see the WEALTH you carry and attempt to take it by force, " +      //Crime lord ending
                         "\nbut you are strong enough to fight them off!" +
                         "\nWith your WEALTH and STRENGTH, you are able to survive in Capitol City as a criminal, " +
                         "\neventually becoming a powerful and rich crime lord!" +
                         "\nGame over!";
            } else if (strength >= 3)
            {
                ending = "\nThe Invaders attack, but you fight them off!" +     //Gladiator ending
                         "\nYou become known throughtout Capitol City as a powerful fighter and are recruited to fight in the arena." +
                         "\nYou live a life of fame as the city's favorite gladiator!" +
                         "\nGame over!";
            }

            return ending;
        }


        static void Main(string[] args)
        {
            //Reputation, Wealth, and Strength variables that will change based on player choices
            int reputation = 1;
            int wealth = 1;
            int strength = 1;

            //Scene 1
            Console.WriteLine("\n--------------------------------------------");   //formatting line

            Console.WriteLine("Scene 1 - The Adventure Begins");
            Console.WriteLine("\nYou set out on the long road in search of adventure with just a sword at your side and a map to Capitol City." + 
                              "\nOn your journey, you come across a caravan on the side of the road that is under attack by bandits!" + 
                              "\nYou see that the merchants could use some help, and you also notice some valuables left unnattended." + 
                              "\nWill you HELP or will you ROB the merchants?");

            Console.Write("\n> ");  //prompt user input line
            
            int choiceNum = playerChoice("HELP", "ROB", "NULL");

            if (choiceNum == 0)     //For invalid choices, ends game
            {
                Console.WriteLine("\nInvalid Input! Sorry, GAME OVER!");
                return;
            }
               
            Console.WriteLine(choiceResponse(choiceNum, ("\nYou choose to HELP the merchants and drive away the bandits!" +      //HELP results
                                                        "\nUnfortunately, one of the bandits runs off with your backpack." +
                                                        "\nThe merchants thank you and offer you a ride to Capitol City." +
                                                        "\n[Your REPUTATION increases by 1, and your WEALTH decreases by 1]"), 

                                                        ("\nYou choose to ROB the merchants, grabbing the discarded valuables and" +      //ROB results
                                                        "\nsneaking around the conflict. You continue on the road to Capitol City!" +
                                                        "\nThe long journey on foot leaves you tired." +
                                                        "\n[WEALTH + 1, REPUTATION - 1, STRENGTH - 1]"), 

                                                        "\nNULL"));     //Not an option

            switch (choiceNum)      //Calculates new values based on choice
            {
                case 1: //HELP
                    reputation += 1;
                    wealth -= 1;
                    break;
                case 2: //ROB
                    wealth += 1;
                    reputation -= 1;
                    strength -= 1;
                    break;
            }

            Console.WriteLine("\n--------------------------------------------");   //formatting line

            //Scene 2
            Console.WriteLine("SCENE 2 - Capitol City");
            Console.WriteLine("After many long days on the road, you finally make it to Capitol City." +
                              "At the gates you are stopped by guards. \"Halt! The city has been invaded, so the gates are closed!\"" + 
                              "You've come so far, you can't turn back!");

            if (choiceNum == 1)
            {
                Console.WriteLine("Will you FIGHT the guards, HELP fight the invaders, or ASK the merchants for help?");
            }
            else
            {
                Console.WriteLine("Will you FIGHT the guards or HELP fight the invaders?");
            }

            Console.Write("\n> ");  //prompt user input line

            choiceNum = 0;      //resetting choiceNum so it can be reused for scene 2

            choiceNum = playerChoice("FIGHT", "HELP", "ASK");

            if (choiceNum == 0)     //For invalid choices, ends game
            {
                Console.WriteLine("\nInvalid Input! Sorry, GAME OVER!");
                return;
            }

            Console.WriteLine(choiceResponse(choiceNum, ("\nYou draw your sword and attempt to fight your way through the guards." +     //FIGHT results
                                                        "\nThough you are injured, you win the fight and continue on through the gates!" + 
                                                        "\n[STRENGTH - 1, REPUTATION - 1]"), 

                                                        ("\nYou offer your help to the guards in fighting the invaders and they agree!" +    //HELP results
                                                        "\nYou march through the gates into Capitol City with the added strength of the guards!" +  
                                                        "\n[STRENGTH + 2]"),

                                                        ("\nYou look to the caravan of merchants for help, " +       //ASK results
                                                        "\nand they negotiate with the guards." + 
                                                        "\nThey agree to let you through! You enter Capitol City with the added strength of the caravan!" + 
                                                        "\n[REPUTATION + 1, STRENGTH + 1]")));

            switch (choiceNum)      //Calculates new values based on choice
            {
                case 1: //FIGHT
                    strength -= 1;
                    reputation -= 1;
                    break;
                case 2: //HELP
                    strength += 2;
                    break;
                case 3: //ASK
                    strength += 1;
                    reputation += 1;
                    break;
            }

            Console.WriteLine("\n--------------------------------------------");   //formatting line

            //Scene 3 (Ending)
            Console.WriteLine("Scene 3 - The Invaders");
            Console.WriteLine("The streets of Capitol City are quiet as you walk along." +
                              "\nSuddenly, you find yourself surrounded by Invaders in bloodied armor!" + 
                              "\nThey prepare to attack!");

            Console.WriteLine(ending(reputation, wealth, strength));    //Calculate final ending based on variables
        }
    }
}
