using Raylib_cs;


namespace PingPongz.Game.Balls
{
    public class Ball
    {

        public float x,y;
        public float speedX, speedY;
        public float radius;
        public Ball()
        {

        }

        public void Draw()
        {
            Raylib.DrawCircle((int)x, (int)y, radius, Color.WHITE);
        }
    }
    
}