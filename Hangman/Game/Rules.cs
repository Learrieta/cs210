using System;

namespace Hangman.Game
{
    public class Rules
    {
        public void Parachute(int p1c)
        {
            if (p1c == 0)
            {
                Console.WriteLine("   __   ");
                Console.WriteLine("  /__\\");
                Console.WriteLine("  \\  / ");
                Console.WriteLine("   \\/");
                Console.WriteLine("    o");
                Console.WriteLine("   /|\\");
                Console.WriteLine("   / \\");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^^^^^^^");
            

            }
            else if (p1c == 1)
            {
                Console.WriteLine("      ");
                Console.WriteLine("  /__\\");
                Console.WriteLine("  \\  / ");
                Console.WriteLine("   \\/");
                Console.WriteLine("    o");
                Console.WriteLine("   /|\\");
                Console.WriteLine("   / \\");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^^^^^^^");
            

            }
            else if (p1c == 2)
            {
                Console.WriteLine("      ");
                Console.WriteLine("  ");
                Console.WriteLine("  \\  / ");
                Console.WriteLine("   \\/");
                Console.WriteLine("    o");
                Console.WriteLine("   /|\\");
                Console.WriteLine("   / \\");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^^^^^^^");
                

            }
            else if (p1c == 3)
            {
                Console.WriteLine("     ");
                Console.WriteLine("  ");
                Console.WriteLine("   ");
                Console.WriteLine("   \\/");
                Console.WriteLine("    o");
                Console.WriteLine("   /|\\");
                Console.WriteLine("   / \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^^^^^^^");
                

            }
            else if (p1c == 4)
            {
               Console.WriteLine("    ");
                Console.WriteLine("  ");
                Console.WriteLine("   ");
                Console.WriteLine("   \\");
                Console.WriteLine("    o");
                Console.WriteLine("   /|\\");
                Console.WriteLine("   / \\");
                Console.WriteLine("");
                Console.WriteLine("^^^^^^^^^^^^^^");
                

            }
            else if (p1c == 5)
            {
                Console.WriteLine("    ");
                Console.WriteLine("  ");
                Console.WriteLine("   ");
                Console.WriteLine("   ");
                Console.WriteLine("    X");
                Console.WriteLine("   /|\\");
                Console.WriteLine("   / \\");
                Console.WriteLine("^^^^^^^^^^^^^^");
                

            }
            


        }
        

        
    }

}