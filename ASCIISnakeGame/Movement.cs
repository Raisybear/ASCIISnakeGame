using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASCIISnake
{
    public class Movement
    {
        static int Snakex = 5;    //Startposition der Schlange
        static int Snakey = 5;
        static char direction = 'w';

        public static void Keyinput()
        {
            Grid.ASCIIgrid(Snakex, Snakey);

            bool GameOn = true;

            while (GameOn == true)
            {
                char Input = Console.ReadKey().KeyChar;

                Console.Clear();

                if (Input == 'w')
                {
                    Snakey--;
                }
                else if (Input == 'a')
                {
                    Snakex--;
                }
                else if (Input == 's' && direction != 'w')
                {
                    Snakey++;
                }
                else if (Input == 'd')
                {
                    Snakex++;
                }

                Grid.ASCIIgrid(Snakex, Snakey);
            }
        }
    }
}
