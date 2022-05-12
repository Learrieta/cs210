using Hilo_Game.Game;

namespace Hilo_Game
{
    class Program{


        static int Main(string[] args)
        {
            Dealer dealer = new Dealer();
            dealer.StartGame();
            return 0;
        }
    }
    
}