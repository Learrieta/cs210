using System;

namespace Hilo_Game.Game{

    public class Card{
        
        public int value1 = 0;

        public int value2 = 0;
        
        

        public Card(){

        }

        public void Shuffle(){
            Random random = new Random();
            value1 = random.Next(1,14);
        }

        public void Shuffle_Two(){
            Random random = new Random();
            value2 = random.Next(1,14);
           
        }

    
    }
}