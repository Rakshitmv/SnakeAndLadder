using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        const int NO_PLAY = 0, LADDER = 1, SNAKE = 2, WINNING_POSITION = 100;
        int playerPosition = 0;
        public void Play()
        {
            Console.WriteLine("The game has begin");
            Random random = new Random();
            int diceOutCome = random.Next(1, 7);
            Console.WriteLine("The dice results is: " + diceOutCome);

            while (playerPosition < WINNING_POSITION)
            {

                int option = random.Next(0, 3);

                switch (option)
                {
                    case NO_PLAY:
                        break;

                    case LADDER:
                        playerPosition += diceOutCome;
                        break;

                    case SNAKE:
                        playerPosition -= diceOutCome;
                        break;
                    default:
                        Console.WriteLine("please enter correct option\n");
                        break;
                        


                }

                Console.WriteLine("Option is: " + option + "\nPlayer position is: " + playerPosition);
            }
        }
    }
}
