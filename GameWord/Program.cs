using System;
using System.Collections.Generic;

namespace GameWord
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var ui = new ConsoleUI();
            var wordBank = new WordBank();
            var difficultyType = ui.ChooseDifficulty();
            var difficulty = new Difficulty(difficultyType);
            var word = wordBank.Generate(difficulty);
            var guessedLetters = new List<char>();
            var attemptsLeft = difficulty.Attempts;

            while (attemptsLeft > 0)
            {
                var mask = word.GetMask(guessedLetters.ToArray());
                ui.ShowGameState(mask, attemptsLeft);

                if (!mask.Contains("*"))
                {
                    Console.WriteLine("You won");
                    return;
                }

                char letter = ui.InputLetter();

                if (guessedLetters.Contains(letter))
                {
                    Console.WriteLine("you already guessed this letter");
                    continue;
                }
                
                guessedLetters.Add(letter);

                if (!word.Contains(letter))
                {
                    attemptsLeft--;
                    Console.WriteLine("Wrong letter. Minus 1 attempt");
                }
                else
                {
                    Console.WriteLine("Right letter, congrats!");
                }
            }
            
            Console.WriteLine("You lost " +
                              "Better luck next time!");
        }
    }
}