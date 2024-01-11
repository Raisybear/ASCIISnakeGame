using ASCIISnake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASCIISnakeGame
{
    public static class GameSettings
    {
        public static int SelectedOption { get; set; } = 1;
    }

    public class Menu
    {
        public static void GameMenu() 
        {           
            int selectedOption = 1; // Startoption
            Grid.Highscore = 0;

            while (true)
            {
                //ASCII Art im Titel von patorjk.com
                Console.WriteLine("   _____             _           _____                      \r\n  / ____|           | |         / ____|                     \r\n | (___  _ __   __ _| | _____  | |  __  __ _ _ __ ___   ___ \r\n  \\___ \\| '_ \\ / _` | |/ / _ \\ | | |_ |/ _` | '_ ` _ \\ / _ \\\r\n  ____) | | | | (_| |   <  __/ | |__| | (_| | | | | | |  __/\r\n |_____/|_| |_|\\__,_|_|\\_\\___|  \\_____|\\__,_|_| |_| |_|\\___|\r\n                                                            \r\n                                                            ");
                Console.WriteLine("Im diesem Snake Game kannst du das Menu und die Schlange mit den Tasten W A S D und der Enter Taste steuern \r\n         ");
                Console.WriteLine("Viel Spass. \r\n      ");

                Console.WriteLine(selectedOption == 1 ? "> 1. Classic Snake" : "  1. Classic Snake");
                Console.WriteLine(selectedOption == 2 ? "> 2. Invincible Snake" : "  2. Invincible Snake");

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                {
                    selectedOption = selectedOption == 1 ? 2 : 1; // ChatGPT
                }
                else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                {
                    selectedOption = selectedOption == 1 ? 2 : 1; // ChatGPT
                }
                else if (key == ConsoleKey.Enter)
                {
                    if (selectedOption == 1)
                    {
                        GameSettings.SelectedOption = selectedOption;
                        Console.Clear();
                        Movement.Keyinput(); // Starte das Snake-Spiel für Option 1
                        break;
                    }
                    else if (selectedOption == 2)
                    {
                        GameSettings.SelectedOption = selectedOption;
                        Console.Clear();
                        Movement.Keyinput(); // Starte das Special Snake Game für Option 2
                        break;
                    }
                }

                Console.Clear();
            }
        }

        public static void DeathMenu() 
        {
            int selectedOption = 1;
            Grid.Highscore = 0;

            while (true)
            {

                Console.WriteLine(selectedOption == 1 ? "> 1. Play Again" : "  1. Play Again");
                Console.WriteLine(selectedOption == 2 ? "> 2. Return To Menu" : "  2. Return To Menu");

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                {
                    selectedOption = selectedOption == 1 ? 2 : 1; // ChatGPT
                }
                else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                {
                    selectedOption = selectedOption == 1 ? 2 : 1; // ChatGPT
                }
                else if (key == ConsoleKey.Enter)
                {
                    if (selectedOption == 1)
                    {
                        GameSettings.SelectedOption = selectedOption;
                        Console.Clear();
                        Movement.Keyinput(); // Starte das Snake-Spiel für Option 1
                        break;
                    }
                    else if (selectedOption == 2)
                    {
                        GameSettings.SelectedOption = selectedOption;
                        Console.Clear();
                        Menu.GameMenu(); // Geht zum Menu
                        break;
                    }
                }

                Console.Clear();
            }
        }
    }
}