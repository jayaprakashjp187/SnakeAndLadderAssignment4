namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to the snake and ladder program!");
            int PlayerPosition = 0;
            int playerPosition2 = 0;
            Console.WriteLine("player position is now starting as zero");
            Console.WriteLine("player position2 is now starting as zero");
            int playerNumberOfRolls = 0;
            int playerNumberOfRolls2= 0;
            int diceTurn = 1;
            Random random = new Random();
            while (diceTurn == 1 || diceTurn == 2)
            {
                int playerDiceRoll = random.Next(1, 7);
                int PlayerDiceRoll2 = random.Next(1, 7);


                if (diceTurn == 1)
                {
                    playerNumberOfRolls++;
                    Console.WriteLine("dice for playernumber of rolls is " + playerDiceRoll);
                    int Player_option = random.Next(0, 3);
                    switch (Player_option)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            break;
                        case 1:
                            PlayerPosition += playerDiceRoll;
                            Console.WriteLine("player position moves a head");
                            break;

                        case 2:
                            PlayerPosition += playerDiceRoll;
                            Console.WriteLine("player position behind!");
                            break;
                    }




                    if (PlayerPosition < 0)
                    {
                        PlayerPosition = 0;
                    }
                    if (PlayerPosition > 100)
                    {
                        PlayerPosition = 100;
                        int difference = PlayerPosition - 100;
                        PlayerPosition = -difference;
                    }

                    Console.WriteLine("the position of player now  " + PlayerPosition);


                    if (PlayerPosition == 100)
                    {
                        Console.WriteLine("the player has won after " + playerNumberOfRolls + "  dice of rolls");
                        diceTurn = 0;
                    }
                    else
                    {
                        if (Player_option != 1)
                        {
                            diceTurn = 2;
                        }
                    }
                }



                else if (diceTurn == 2)
                {
                    playerNumberOfRolls2++;
                    Console.WriteLine("Dice for Player 2 Rolled: " + PlayerDiceRoll2);

                    int Player_Option2 = random.Next(0, 3);
                    switch (Player_Option2)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            break;
                        case 1:
                            playerPosition2 += PlayerDiceRoll2;
                            Console.WriteLine("player position moves a head");
                            break;
                        case 2:
                            playerPosition2 -= PlayerDiceRoll2;
                            Console.WriteLine("player position moves a behind");
                            break;
                    }

                    if (playerPosition2 < 0)
                    {
                        playerPosition2 = 0;
                    }

                    if (playerPosition2 > 100)
                    {

                        int diff = playerPosition2 - 100;
                        playerPosition2 = -diff;

                    }


                    Console.WriteLine("The position for Player 2 is : " + playerPosition2);
                    if (playerPosition2 == 100)
                    {
                        Console.WriteLine("The Player 2 Has Won, after total " + playerNumberOfRolls2 + " dice of  rolls");
                        diceTurn = 0;
                    }
                    else
                    {
                        if (playerPosition2 != 1)
                        {
                            diceTurn = 1;
                        }
                    }
                }
            }
        
        }
    }
}