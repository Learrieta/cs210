using Hangman.Game;

namespace Hangman
{
    class Program{


        static int Main(string[] args)
        {
           Director d = new Director();
           d.StartGame();
           return 0;
        }
    }
    
}