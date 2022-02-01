using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeAndLadder
    {
        public void Play()
        {

            int startPosition = 0;
            Console.WriteLine("The game has begin");
            Random random = new Random();
            int diceOutCome = random.Next(1, 7);
            Console.WriteLine("The dice result is: " + diceOutCome);

        }
    }
}
