using System;
using System.Xml;

namespace Lab4take2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            int parsedValue;
            while (playAgain)
            {
                Console.WriteLine("Learn your squares and cubes! \nPlease enter an integer.");
                string userInput = Console.ReadLine();

                bool parsedTrue = int.TryParse(userInput, out parsedValue);
                bool validNumber = parsedTrue;
                if (validNumber)
                {
                    Console.WriteLine("Number\tSquared\tCubed");
                    Console.WriteLine("=======\t=======\t=======");
                    for (int i = 1; i <= parsedValue; i++)
                    {
                        Console.WriteLine($"{i}\t{squareNum(i)}\t{cubeNum(i)}");
                    }
                    Console.WriteLine("Want to try again? Press any key to continue or x to quit.");
                    string userContinue = Console.ReadLine().ToLower();
                    if (userContinue == "x")
                        playAgain = false;
                }
                else
                {
                    Console.WriteLine("That is not a valid answer please try again.");
                }
            }
        }
    
    public static int squareNum(int number)
    {
        int userNum = number * number;
        return userNum;
    }

    public static int cubeNum(int number)
        {
        int userNum = number * number * number;
        return userNum;
        }
    }
}
