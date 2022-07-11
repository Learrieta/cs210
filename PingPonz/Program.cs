using Raylib_cs;
using PingPongz.Game.Balls;
using PingPongz.Game.Paddles;
using PingPongz.Game.Score;
using System.Numerics;


namespace PingPongz
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        /// <summary>
        
        static void Main(string[] args)
        {
            Raylib.InitWindow(800,600, "Pongz");
            Raylib.SetWindowState(ConfigFlags.FLAG_VSYNC_HINT);



            Ball ball  = new Ball();
            ball.x = Raylib.GetScreenWidth() / 2.0f;
            ball.y = Raylib.GetScreenHeight()/ 2.0f;
            ball.radius = 5;
            ball.speedX = 300;
            ball.speedY = 300;
            

            Paddle leftPaddle = new Paddle();
            leftPaddle.x = 50;
            leftPaddle.y = Raylib.GetScreenHeight() / 2;
            leftPaddle.width = 10;
            leftPaddle.height = 100;
            leftPaddle.speed = 500;

            

            

            Paddle rightPaddle = new Paddle();
            rightPaddle.x = Raylib.GetScreenWidth() -50;
            rightPaddle.y = Raylib.GetScreenHeight() / 2;
            rightPaddle.width = 10;
            rightPaddle.height = 100;
            rightPaddle.speed = 500;

            Scores score = new Scores();
            score.s = 0;
            



            bool  winnerText = false;
            string whoisthewinner = "";

            string scoreKeep = "";

            while(!Raylib.WindowShouldClose())
            {
                ball.x += ball.speedX * Raylib.GetFrameTime();
                ball.y += ball.speedY * Raylib.GetFrameTime();

                if(ball.y <0 )
                {
                    ball.y = 0;
                    ball.speedY *= -1;
                }
                if(ball.y > Raylib.GetScreenHeight())
                {
                    ball.y = Raylib.GetScreenHeight();
                    ball.speedY *= -1;
                }

                if(Raylib.IsKeyDown(KeyboardKey.KEY_W))
                {
                    leftPaddle.y -= leftPaddle.speed * Raylib.GetFrameTime();
            
                }
                if(Raylib.IsKeyDown(KeyboardKey.KEY_S))
                {
                    leftPaddle.y += leftPaddle.speed * Raylib.GetFrameTime();
            
                }

                
                if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    rightPaddle.y -= rightPaddle.speed * Raylib.GetFrameTime();
            
                }
                if(Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    rightPaddle.y += rightPaddle.speed * Raylib.GetFrameTime();
            
                }

                Vector2 vector = new Vector2(ball.x, ball.y);
                if(Raylib.CheckCollisionCircleRec(vector, ball.radius, leftPaddle.GetRec()))
                {
                    if(ball.speedX < 0)
                    {
                        ball.speedX *= -1.1f;
                        ball.speedY = (ball.y - leftPaddle.y) / (leftPaddle.height / 2) * ball.speedX;
                    }
                   

                }
                if(Raylib.CheckCollisionCircleRec(vector, ball.radius, rightPaddle.GetRec()))
                {
                    if(ball.speedX > 0 )
                    {
                        ball.speedX *= -1.1f;
                        ball.speedY = (ball.y - rightPaddle.y) / (rightPaddle.height / 2) * - ball.speedX ;
                    }
                }
                if (ball.x < 0)
                {
                    winnerText = true;
                    whoisthewinner = "Right Player Wins";
                    score.s += 1;
                    scoreKeep = Convert.ToString(score.s);
                    Raylib.DrawText(scoreKeep, 730, 20, 60, Color.BLUE );
                }
                if(ball.x > Raylib.GetScreenWidth())
                {
                    winnerText = true;
                    whoisthewinner = "Left Player Wins";
                    score.s += 1;
                    scoreKeep = Convert.ToString(score.s);
                    Raylib.DrawText(scoreKeep, 40, 20, 60, Color.BLUE );
                    
                }
                if(winnerText == true && Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                {
                    ball.x = Raylib.GetScreenWidth() / 2.0f;
                    ball.y = Raylib.GetScreenHeight()/ 2.0f;
                    ball.speedX = 300;
                    ball.speedY = 300;
                    winnerText = false;
                }



                Raylib.BeginDrawing();
                    Raylib.ClearBackground(Color.BLACK);
                    ball.Draw();
                    leftPaddle.Draw();
                    rightPaddle.Draw();

                   


                    if(winnerText)
                    {
                        int textwidth = Raylib.MeasureText(whoisthewinner, 60);
                        Raylib.DrawText(whoisthewinner, Raylib.GetScreenWidth() / 2 - textwidth/2, Raylib.GetScreenHeight() / 2 -30, 60, Color.YELLOW);
                        
                    }
                   



                    Raylib.DrawFPS(10, 10);
                
                Raylib.EndDrawing();
            
            

            }
            Raylib.CloseWindow();

        }
    }
}