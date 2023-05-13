namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the snake and ladder program!");
            int PlayerPosition = 0;
            Console.WriteLine("singleplayer position is now starting as zero");
            int playerNumberOfRolls = 0; // number of times the dice was rolled
            Random random = new Random();
            while (PlayerPosition < 100)
            {
                int playerDiceRoll = random.Next(1, 7);
                playerNumberOfRolls++;

                Console.WriteLine("the player rolled a dice is   " + playerDiceRoll);
                int checkOptions = random.Next(0, 3);
                switch (checkOptions)
                {
                    case 0:
                        Console.WriteLine("No play");
                        break;
                    case 1:
                        PlayerPosition += playerDiceRoll;
                        Console.WriteLine("player position moves a head");
                        break;
                    case 2:
                        PlayerPosition -= playerDiceRoll;
                        Console.WriteLine("player position moves a behind");
                        break;
                }
                if (PlayerPosition < 0)
                {
                    PlayerPosition = 0;
                }

                Console.WriteLine("the position of player now  " + PlayerPosition);

            }
        }
    }
}