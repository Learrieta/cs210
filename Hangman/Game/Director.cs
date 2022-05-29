using System;
using static System.Random;

namespace Hangman.Game
{
    public class Director
    {
        Player playerone = new Player();
        Rules r = new Rules();
        public Director()
        {
        }
        public void StartGame()
        {
            Console.WriteLine("welcome to Jumpman");
            Console.WriteLine("Can you guess the song from Post Malone?");
            Console.WriteLine("");
            Random random = new Random();
            List<string> wordDic = new List<string> {"wow","congratulations","sunflower","psycho","circles"};
            int index  = random.Next(wordDic.Count);
            String randonWord = wordDic[index];
            foreach( char x in randonWord)
            {
                Console.Write("_ ");
            }
            int lengthOfWordToGuess = randonWord.Length;
            int amountOfTimeWrong = 0;
            List<char> currentLettersGuessed = new List<char>();
            int currentLettersRight = 0;
            while ( amountOfTimeWrong != 5 && currentLettersRight != lengthOfWordToGuess)
            {
                Console.Write("\nLetters guessed so far: ");
                foreach (char letter in currentLettersGuessed)
                {
                    Console.Write(letter + " ");
                }
                playerone.makeChoice();
                char choices = playerone.getChoice();
                if ( currentLettersGuessed.Contains(choices))
                {
                    Console.WriteLine("\r\n You have already guessed this letter");
                    r.Parachute(amountOfTimeWrong);
                    currentLettersRight = printWord(currentLettersGuessed, randonWord);
                    printLines(randonWord);
                }else{
                    bool right  = false;
                    for ( int i = 0; i < randonWord.Length; i++)
                    {
                        if (choices == randonWord[i])
                        {
                            right = true;
                        }
                    }
                    if (right)
                    {
                        r.Parachute(amountOfTimeWrong);
                        currentLettersGuessed.Add(choices);
                        currentLettersRight = printWord(currentLettersGuessed, randonWord);
                        Console.Write("\r\n");
                        printLines(randonWord);
                    }else{
                        amountOfTimeWrong +=1;
                        currentLettersGuessed.Add(choices);
                        r.Parachute(amountOfTimeWrong);
                        currentLettersRight = printWord(currentLettersGuessed, randonWord);
                        Console.Write("\r\n");
                        printLines(randonWord);
                    }
                }

            }
            Console.WriteLine("\r\nGame is over! Thank you for playing :)");
        
                
        }

        public static int printWord(List<char> guessedLetters, String randonWord)
        {
            int counter = 0;
            int rightLetters = 0;
            Console.Write("\r\n");
            foreach ( char c in randonWord)
            {
                if (guessedLetters.Contains(c))
                {
                    Console.Write(c + " ");
                    rightLetters += 1;
                }else{
                    Console.Write("  ");
                }
                counter += 1;
            }
            return rightLetters;
        }

        public static void printLines(String randonWord)
        {
            Console.Write("\r");
            foreach( char c in randonWord)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\u0305");
            }
        }


    }
}