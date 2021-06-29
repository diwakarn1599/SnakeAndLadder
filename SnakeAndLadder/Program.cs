using System;

namespace SnakeAndLadder
{
    /// <summary>
    ///  Code for Snake and Ladder  Game 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //welcome message
            Console.WriteLine("Welcome to Snake and ladder problem");

            //initializing object for playgame class
            PlayGame pg = new PlayGame();

            //calling a method using object
            pg.StartGame();

        }
    }
}
