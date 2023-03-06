//Son Tran April 1st 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class GuessTheNumberGame
    {
        private int guessCount = 0;
        private string? input = string.Empty;

        bool isValid = false;
        private const int MAX_MENU = 3;
        private const int MIN_MENU = 0;

        private RangedRandomInterger secretNumberGenerator = new();

        public GuessTheNumberGame()
        {

        }

        private void Play(int secretNumber)
        {
            guessCount = 1;
            Console.WriteLine("Guess The Number!");
            input = Console.ReadLine();
            while (int.Parse(input) != secretNumber)
            {
                if (int.Parse(input) > secretNumber)
                {
                    guessCount++;
                    Console.WriteLine("Number too high!!!!!");
                    input = Console.ReadLine();
                }                
                else if (int.Parse(input) < secretNumber)
                {
                    guessCount++;
                    Console.WriteLine("Number too low!!!!!");
                    input = Console.ReadLine();
                }
            }
            Console.WriteLine($"Congrats, you got it after {guessCount} attempts");
            Console.WriteLine();

        }

        private int Setup(int rangeOption)
        {
             secretNumberGenerator.SetMinimum(1);
            //int secretNumber;
            switch (rangeOption)
            {
                case 0:
                    Console.WriteLine("See you next time!");
                    System.Environment.Exit(0);
                    break;
                case 1:
                    secretNumberGenerator.SetMaximum(10);
                    break;                
                case 2:
                    secretNumberGenerator.SetMaximum(100);
                    break;                
                case 3:
                    secretNumberGenerator.SetMaximum(1000);
                    break;
            }
            
            return secretNumberGenerator.GenerateRandomNumber();
        }

        public int showMenu()
        {
            Console.Clear();

            Console.WriteLine("______________________________________________________");
            Console.WriteLine("|                Made by Son Tran                    |");
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|  1: Easy   (1-10)                                  |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|  2: Normal (1-100)                                 |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|  3: Hard   (1-1000)                                |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|  0: Exit                                           |");
            Console.WriteLine("|____________________________________________________|");
        
            Console.WriteLine();
            Console.Write("Choose a game mode: ");
            input = Console.ReadLine();

            do
            {
                try
                {
                    if (int.Parse(input) > MAX_MENU || int.Parse(input) < MIN_MENU)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        isValid = true;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input, please enter a valid number");
                    input = Console.ReadLine();
                }
            }
            while (!isValid);

            return Setup(int.Parse(input));
        }
        public void Start()
        {
            int secretNumber =  showMenu();
            Play(secretNumber);

            Console.WriteLine("Do you want to play again? Y/N");
            input = Console.ReadLine();
            do
            {
                if (input.ToLower() == "y")
                {
                    Start();
                }
                else if (input.ToLower() == "n")
                {
                    Console.WriteLine("Thats a shame :(");
                    System.Environment.Exit(0);
                }
                else
                {
                Console.WriteLine("Invalid input");
                input = Console.ReadLine();
                }
            }
            while (input.ToLower() != "y" || input.ToLower() != "n");
        }
    }
}
