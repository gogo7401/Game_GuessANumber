using System;

namespace GuessANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Are you ready for a new game? ([Y]es or [N]o): ");
            string playerChoice = Console.ReadLine();
            while (true)
            {
                if (playerChoice == "N" || playerChoice == "n" || playerChoice == "No" || playerChoice == "NO")
                {
                    Console.WriteLine("Good bye!");
                    return;
                }
                else if (playerChoice != "Y" && playerChoice != "y" && playerChoice != "Yes" && playerChoice != "YES")
                {
                    Console.WriteLine("Your choice is incomprehensible to me!");
                    Console.Write("Let's play again? ([Y]es or [N]o): ");
                    playerChoice = Console.ReadLine();
                }
                else
                {
                    // Began write a game

                    Random random = new Random();
                    int computerNumber = random.Next(1, 101);
                    int gamerNumber = 0;
                    while (computerNumber != gamerNumber)
                    {
                        bool isValidNumber = false;
                        while (!isValidNumber)
                        {
                            Console.Write("Guess a number (1-100): ");
                            string gamerInput = Console.ReadLine();
                            bool isValidInteger = int.TryParse(gamerInput, out gamerNumber);
                            if (isValidInteger)
                            {
                                if (gamerNumber >= 1 && gamerNumber <= 100)
                                {
                                    isValidNumber= true;
                                }
                                else
                                {
                                    Console.WriteLine("Enter a number in the range 1-100. Try again!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Entered is not a number! Try again! ");
                            }
                        }
                        if (computerNumber==gamerNumber)
                        {
                            Console.WriteLine("You guessed it!");
                        }
                        else if (gamerNumber > computerNumber)
                        {
                            Console.WriteLine("Too high!");
                        }
                        else if (gamerNumber < computerNumber)
                        {
                            Console.WriteLine("Too low!");
                        }
                    }

                    Console.Write("Are you ready for a new game? ([Y]es or [N]o): ");
                    playerChoice = Console.ReadLine();
                    Console.Clear();
                }

            }
        }
    }
}
