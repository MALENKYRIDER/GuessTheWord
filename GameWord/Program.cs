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
            
            var game = new Game(difficulty, word);

            while (!game.IsWon && !game.IsLost)
            {
                ui.ShowGameState(game.Mask, game.AttemptsLeft, game.GuessedLetters);
                char letter = ui.InputLetter();
                game.Guess(letter);
            }

            if (game.IsWon) 
                Console.WriteLine("Congratulations! You won the game!");
            else
                Console.WriteLine("You lost the game! Better luck next time!");
        }
    }
}