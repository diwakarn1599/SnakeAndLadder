using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    
    class PlayGame
    {
        //initialising constant variable
        public const int START_POSITION = 0;
        public const int NO_PLAY = 1;
        public const int LADDER = 2;
        public const int SNAKE = 3; 


        //Method for start game
        public void StartGame()
        {
            //Console.WriteLine("Player position starts with "+ START_POSITION);
            int diceRoll,checkOption,playerPosition = START_POSITION;
            int winningPosition = 100;

            //initialisng random class
            Random rand = new Random();

            

            //Console.WriteLine(checkOption);
            while (playerPosition < winningPosition)
            {
                //Generating random number for diceRoll
                diceRoll = rand.Next(1, 7);

                //generating random for checking options
                checkOption = rand.Next(1, 4);

                switch (checkOption)
                {
                    case NO_PLAY:
                        //Console.WriteLine("No play --> Player position= " + playerPosition);
                        break;
                    case LADDER:
                        playerPosition += diceRoll;
                        //Console.WriteLine("Ladder --> Player position= " + playerPosition);
                        break;
                    case SNAKE:
                        playerPosition = (playerPosition - diceRoll) < 0 ? 0 : (playerPosition - diceRoll);
                        //Console.WriteLine("Snake --> Player position= " + playerPosition);
                        break;
                    default:
                        break;
                }
                if (playerPosition > winningPosition)
                {
                    playerPosition = playerPosition - diceRoll;
                }
                Console.WriteLine("Player position= "+ playerPosition);
            }
            
            //Console.WriteLine("The player throws "+ diceRoll);
            Console.WriteLine("Congratulations!!! You Won!!! \n  player Position =" + playerPosition);





        }

    }
}
