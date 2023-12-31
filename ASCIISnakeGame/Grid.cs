using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASCIISnake
{
    public class Grid
    {
        public static void ASCIIgrid(int snakey, int snakex)
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (i == snakex && j == snakey)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[■]"); //Zeichnen der Schlange an neuer Position
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("[ ]"); //Restliches wird mit Leeren Klammern gefüllt
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
