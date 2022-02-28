using System;

namespace ChallengeIfStatement
{
    class Program
    {
        public static int score;
        public static int highScore;
        public static string highScorePlayer;

        static void Main(string[] args)
        {
            Callplayer(100, "teste");
            Callplayer(200, "james");
            Callplayer(300, "Zé");

            Console.Read();
        }

        public static void Callplayer(int score, string player)
        {
              /*
               * usar variaveis publicas no metodo callplayer
               * Console.WriteLine("Whats the name of the player?");
              string player = Console.ReadLine();
              Console.WriteLine("Whats the score?");
              string strScore = Console.ReadLine();
              score = int.Parse(strScore);*/

            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = player;
                Console.WriteLine("New highscore is {0}", score);
                Console.WriteLine("New highscore holder is " + player);
            }
            else
            {
                Console.WriteLine("The old highscore of " + highScore + " could not be broken and is still held by " + highScorePlayer);
            }
        }
    }
}
