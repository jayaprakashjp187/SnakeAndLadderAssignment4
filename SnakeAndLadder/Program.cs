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

            int playerDiceRoll = random.Next(1, 7);
            playerNumberOfRolls++;

            Console.WriteLine("the player rolled a dice is   " + playerDiceRoll);
        }
    }
}
