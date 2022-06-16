namespace Greed.Game.Casting
{
        public class Artifact : Actor
        {
            private string message = "";

            public int points = 0;

            public int velocity = (15);

            public Artifact()
            {

            }
            public string GetMessage()
            {
                return message;

            }

            public void SetMessage( string message)
            {
                this.message = message;
            }
            public int getPoints()
            {
                return points;
            }
            public void setPoint(int points){
                this.points = points;

            }


        }
    
}