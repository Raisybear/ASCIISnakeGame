﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ASCIISnake
{
    public class Grid
    {
        public static bool applePlaced = false;
        public static int appleNumx;
        public static int appleNumy;

        public static int Highscore { get; set; }

        public static void ASCIIgrid(int snakey, int snakex)
        {
            if (!applePlaced)
            {
                Random myObject = new Random();
                appleNumx = myObject.Next(0, 11);
                appleNumy = myObject.Next(0, 11);
                applePlaced = true;
            }

            bool appleEaten = false;

            if (snakex == appleNumx && snakey == appleNumy)
            {
                Highscore++;
                appleEaten = true;
                applePlaced = false; // Setze den Apfel neu
            }

            for (int i = 0; i < 11; i++)        
            {
                for (int j = 0; j < 11; j++)    
                {
                    if (i == snakex && j == snakey)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("[■]");   //Zeichnen der Schlange an neuer Position
                        Console.ResetColor();
                    }
                    else if (i == appleNumx && j == appleNumy)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("[■]");   //Zeichnen des Apfels
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("[ ]");   //Restliches wird mit Leeren Klammern gefüllt
                    }

                    
                }
                Console.WriteLine();
            }

            if (appleEaten)
            {
                applePlaced = false;
            }
        }
    }
}
