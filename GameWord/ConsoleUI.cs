using System;

namespace GameWord
{
    public class ConsoleUI
    {
        public char InputLetter()
        {
            Console.Write("Enter a letter: ");

            while (true)
            {
                var inputLetter = Console.ReadLine();
                
                if (!string.IsNullOrEmpty(inputLetter) && 
                    inputLetter.Length == 1 && 
                    char.IsLetter(inputLetter[0]))
                    
                    return (inputLetter[0]);
            }
        }

        public DifficultyType ChooseDifficulty()
        {
            Console.WriteLine("Choose difficulty: \n"+
                              "1 - Easy\n"+
                              "2 - Normal\n"+
                              "3 - Hard");

            while (true)
            {
                var inputDifficulty = Console.ReadLine();

                switch (inputDifficulty)
                {
                    case "1":
                        return DifficultyType.Easy;
                    case "2":
                        return DifficultyType.Normal;
                    case "3":
                        return DifficultyType.Hard;
                    default:
                        Console.WriteLine("Incorrect chose. Please select a difficulty.");
                        break;
                }
            }
        }
        
        public void ShowGameState(string maskedWord, int attempts)
        {
            Console.WriteLine();
            Console.WriteLine($"Word: {maskedWord}");
            Console.WriteLine($"Attempts left: {attempts}");
        }
    }
}