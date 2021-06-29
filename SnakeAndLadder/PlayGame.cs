using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    
    class PlayGame
    {
        //initialising constant variable
        public const int START_POSITION = 0;

        //Method for start game
        public void StartGame()
        {
            //Console.WriteLine("Player position starts with "+ START_POSITION);
            int diceRoll;
            //initialisng random class
            Random rand = new Random();

            //Generating random number for diceRoll
            diceRoll = rand.Next(1, 7);

            Console.WriteLine("The player throws "+ diceRoll);





        }

    }
}
