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

        // Initializing static variables
        public static int playerOnePosition = START_POSITION;
        public static int playerTwoPosition = START_POSITION;
        public static int countDieRoll = 0;
        public static int countDieRollP1 = 0;
        public static int countDieRollP2 = 0;

        //Initialzing global variable
        int winningPosition = 100;
        int diceRoll, checkOption;

        Random rand = new Random();

        //Method for start game
        public void StartGame()
        {
            PlayerOne();
        }

        //Player One Method
        public void PlayerOne()
        {
            if (playerOnePosition == winningPosition)
            {
                Console.WriteLine("**********Player One Won**********");
                Console.WriteLine("Total Dice Roll = " + countDieRoll);
                return;
            }

            //Generating random number for diceRoll
            diceRoll = rand.Next(1, 7);

            //generating random for checking options
            checkOption = rand.Next(1, 4);
            Console.WriteLine("Player One Dice Roll = "+ ++countDieRollP1);
            ++countDieRoll;
            switch (checkOption)
            {
                case NO_PLAY:
                    Console.WriteLine("No play --> Player One position= " + playerOnePosition);
                    PlayerTwo();
                    break;
                case LADDER:
                    playerOnePosition += diceRoll;
                    // condition to check whether player position be exactly 100
                    playerOnePosition = playerOnePosition > winningPosition ? (playerOnePosition - diceRoll) : playerOnePosition;
                    Console.WriteLine("Ladder --> Player One position= " + playerOnePosition);
                    PlayerOne();
                    break;
                case SNAKE:
                    playerOnePosition = (playerOnePosition - diceRoll) < 0 ? 0 : (playerOnePosition - diceRoll);
                    Console.WriteLine("Snake --> Player One position= " + playerOnePosition);
                    PlayerTwo();
                    break;
                default:
                    break;
            }
            
        }

        //Player Two Method
        public void PlayerTwo()
        {
            if (playerTwoPosition == winningPosition)
            {
                Console.WriteLine("*******Player Two Won*******");
                Console.WriteLine("Total Dice Roll = " + countDieRoll);
                return;
            }
            //Generating random number for diceRoll
            diceRoll = rand.Next(1, 7);

            //generating random for checking options
            checkOption = rand.Next(1, 4);

            //printing count of dice rolled for each player
            Console.WriteLine("Player Two Dice Roll = " + ++countDieRollP2);
            ++countDieRoll;

            switch (checkOption)
            {
                case NO_PLAY:
                    Console.WriteLine("No play --> Player Two position= " + playerTwoPosition);
                    PlayerOne();
                    break;
                case LADDER:
                    playerTwoPosition += diceRoll;
                    // condition to check whether player position be exactly 100
                    playerTwoPosition = playerTwoPosition > winningPosition ? (playerTwoPosition - diceRoll) : playerTwoPosition;
                    Console.WriteLine("Ladder --> Player Two position= " + playerTwoPosition);
                    PlayerTwo();
                    break;
                case SNAKE:
                    playerTwoPosition = (playerTwoPosition - diceRoll) < 0 ? 0 : (playerTwoPosition - diceRoll);
                    Console.WriteLine("Snake --> Player Two position= " + playerTwoPosition);
                    PlayerOne();
                    break;
                default:
                    break;
            }
            

            

        }

    }
}
