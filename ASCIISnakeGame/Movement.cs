using ASCIISnake;
using ASCIISnakeGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ASCIISnake
{
    public class Movement
    {
        static int Snakex = 5;    //Startposition der Schlange
        static int Snakey = 5;
        static char direction = 'd';
        static bool GameOn = true;

        public static void Keyinput()
        {
            Grid.ASCIIgrid(Snakex, Snakey);
            System.Threading.Thread.Sleep(1500);

            while (GameOn == true)
            {
                if (Console.KeyAvailable)
                {
                    var Input = Console.ReadKey(true).Key;

                    if (Input == ConsoleKey.W && direction != 's')
                    {
                        direction = 'w';
                    }
                    else if (Input == ConsoleKey.A && direction != 'd')
                    {
                        direction = 'a';
                    }
                    else if (Input == ConsoleKey.S && direction != 'w')
                    {
                        direction = 's';
                    }
                    else if (Input == ConsoleKey.D && direction != 'a')
                    {
                        direction = 'd';
                    }
                }

                if (GameSettings.SelectedOption == 1)
                {
                    MoveSnake();
                    Console.Clear();
                    Grid.ASCIIgrid(Snakex, Snakey);

                    System.Threading.Thread.Sleep(250);
                }

                if (GameSettings.SelectedOption == 2)
                {
                    MoveSnakeSpecial();
                    Console.Clear();
                    Grid.ASCIIgrid(Snakex, Snakey);

                    System.Threading.Thread.Sleep(100);
                }

                if (!GameOn)
                {
                    Snakex = 5;
                    Snakey = 5;
                    direction = 'd';
                    GameOn = true;
                    Console.Clear();
                    Console.WriteLine("Game Over!");
                    System.Threading.Thread.Sleep(1500);
                    Console.Clear();
                    Menu.DeathMenu();
                    break;
                }
            }
        }

        static void MoveSnake()
        {
            // Bewege die Schlange kontinuierlich in die aktuelle Richtung
            if (Snakex == 0 || Snakex == 10 || Snakey == 0 || Snakey == 10)
            {
                if (!(direction == 'w' && Snakey == 0) && !(direction == 'a' && Snakex == 0) &&     //ChatGPT
                    !(direction == 's' && Snakey == 10) && !(direction == 'd' && Snakex == 10))     //ChatGPT
                {
                    if (direction == 'w')
                    {
                        Snakey--;
                    }
                    else if (direction == 'a')
                    {
                        Snakex--;
                    }
                    else if (direction == 's')
                    {
                        Snakey++;
                    }
                    else if (direction == 'd')
                    {
                        Snakex++;
                    }
                }
                else
                {
                    GameOn = false;
                    Console.WriteLine("Game Over! You hit the wall.");
                }
            }
            else
            {
                if (direction == 'w')
                {
                    Snakey--;
                }
                else if (direction == 'a')
                {
                    Snakex--;
                }
                else if (direction == 's')
                {
                    Snakey++;
                }
                else if (direction == 'd')
                {
                    Snakex++;
                }
            }
        }

        static void MoveSnakeSpecial()
        {
            if (Snakex < 0)
            {
                Snakex = 11;
            }
            else if (Snakex > 11) 
            {
                Snakex = 0;
            }
            else if (Snakey > 11)
            {
                Snakey = 0;
            }
            else if (Snakey < 0)
            {
                Snakey = 11;
            }
            
            if (direction == 'w')
            {
                Snakey--;
            }
            else if (direction == 'a')
            {
                Snakex--;
            }
            else if (direction == 's')
            {
                Snakey++;
            }
            else if (direction == 'd')
            {
                Snakex++;
            }
        }
    }
}
