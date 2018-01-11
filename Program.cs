using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace LäroverketFighters
{
    class Program
    {
        static Random randomness = new Random();
        static int playerHP = randomness.Next(10, 20);
        static int enemyHP = randomness.Next(8, 18);

        static int playerDMG = randomness.Next(2, 6);
        static int enemyDMG = randomness.Next(1, 5);

        static string userInput;

        static void Main(string[] args)
        {
            Console.Title = "Lennart Fighters";
            Console.SetWindowSize(30, 10);

            
            
            //Game loop. As long as both lives, do this
            while (playerHP > 0 && enemyHP > 0)
            {
                Console.Clear();

                DisplayStats();

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("1: Attack \n2: Heal\n\nUser input");
                userInput = Console.ReadLine();

                //User choice
                if (userInput == "1") //attack
                {
                    playerDMG = randomness.Next(2, 6);
                    enemyHP -= playerDMG;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Player attacked for " + playerDMG);

                }
                else if(userInput == "2") //heal
                {
                    int healAmount = randomness.Next(1, 3);
                    playerHP += healAmount;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Player healed for " + playerDMG);

                }
                else //Invalid menu input
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid Input!");

                    Console.ReadKey(); //Pause until user presses key
                    continue;
                }

                EnemyTurn();
                Console.ReadKey(); //Pause until user presses key
            } //end of while loop

            //If we are here someone died
            if (enemyHP < 1)
            {
                //If enemy died
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\nEnemy died!!");
            }
            else
            {
                //If player died
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nYou died :(");
            }


            Console.ReadKey();
        }

        static void EnemyTurn()
        {
            if(randomness.Next(0, 10) >= 2)
            {
                int healAmount = randomness.Next(1, 3);
                playerHP += healAmount;
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Player healed for " + playerDMG);
            }
            else
            {
                playerHP -= enemyDMG;
                enemyDMG = randomness.Next(1, 5);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Enemy attacked for " + enemyDMG);

            }



        }

        static void DisplayStats()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Player HP:" + playerHP);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enemy HP:" + enemyHP);
        }
    }
}
