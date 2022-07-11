using Raylib_cs;
using System.Collections;
using System.Collections.Generic;


namespace PingPongz.Game.Paddles
{
    public class Paddle
    {
        public float x, y;
        public  float speed;

        public float width, height;



        public Paddle()
        {

        }



        public void Draw()
        {
            Raylib.DrawRectangle((int)x - (int)width / 2, (int)y - (int)height / 2, 10, 100, Color.WHITE );

        }

        public Rectangle GetRec()
        {
            Rectangle recs = new Rectangle ((int)x - (int)width / 2, (int)y - (int)height / 2, 10, 100);

            return recs;
        }


       
        
    }
}