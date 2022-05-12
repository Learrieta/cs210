using System;
using System.Collections.Generic;

namespace Hilo_Game.Game{

    public class Dealer{
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int score = 0;

        int totalScore = 300;
        

        string deck1 = "";

        string deck2 = "";

        string answer = "";

        string keep_playing = "";

        public Dealer()
        {
            for (int i = 0; i < 1; i++)
            {
                Card card = new  Card();
                cards.Add(card);
            }

        }

        public void StartGame()
        {
            while (isPlaying)
            {
                TheCardIs();
                GetInputs();
                NewCardIs();
                Points();
                KeepPlaying();
                
            }
        }

        public void TheCardIs()
        {
            if (keep_playing == "y")
            {
                Console.WriteLine($"The card is: {deck2}");
            } else 
            {
                foreach (Card card in cards)
                {
                card.Shuffle();
                deck1 = $"{card.value1}";
                }
                Console.WriteLine($"The card is: {deck1}.");

            }
            
        }

        public void GetInputs()
        {
            Console.Write("Higher or lower? [high/low] ");
            answer  = Console.ReadLine();
            
        }
        public void NewCardIs()
        {
            foreach (Card card in cards)
            {
                card.Shuffle_Two();
                deck2 = $"{card.value2}";
            }
            Console.WriteLine($"Next card was : {deck2}.");
        
        }
        public void Points()
        {
            int de1 = Int32.Parse(deck1);
            int de2 = Int32.Parse(deck2);
            if ( answer == "high" & de1 < de2)
            {
                score = 100;
            }else if ( answer == "low" & de1 > de2)
            {
                score = 100;
            } else {
                score = -75;
            }

            totalScore += score;
            Console.WriteLine($"Your score is: {totalScore}.");
            isPlaying = (totalScore > 0);
        }
        public void KeepPlaying()
        {
            Console.Write("Keep Playing? [y/n]");
            keep_playing  = Console.ReadLine();
            isPlaying = (keep_playing== "y");
        }


    }

}