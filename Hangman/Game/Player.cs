using System;

namespace Hangman.Game
{
    public class Player
    {
        private char choice;
        

        public void makeChoice()
        {
            Console.WriteLine("Guess a letter [a-z]: ");
            choice = Console.ReadLine()[0];
            choice = char.ToLower(choice);
        }

        public char getChoice()
        {
            return choice;
        }

        

    }

}