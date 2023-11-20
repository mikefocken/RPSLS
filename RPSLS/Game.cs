using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Security;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {

            {
                Console.WriteLine("Welcome to ROCKS PAPERS SCISSORS LIZARDS & SPOCK! Here are the rules:\n");
                Console.WriteLine("Anyone can play Rock Paper Scissors the old school way,but we added a few more options to make it more exciting.");
                Console.WriteLine("rock smashes scissors,scissors cuts paper, paper covers rock,Rock smashes lizard,lizard poisons spock, spock smashes scissors, scissors decapitates lizard,Lizard eats paper");
                Console.WriteLine("The game will play until one player wins the best of three games!");
                Console.WriteLine(" if you don't have a friend to play the game with, you can play against the computer");
                
            }

            //Member Methods (CAN DO)


        }

        public void WelcomeMessage()

        {
         
                      
            
        }

        public int ChooseNumberOfHumanPlayers()
                
        {
            Console.WriteLine($" please choose between 1 and 2 players");
            string response = Console.ReadLine();
            int convertReturn = int.Parse(response);
           
            return convertReturn;
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers) 

        {
            Console.WriteLine("What is Player One's name?");
            playerOne = new HumanPlayer(Console.ReadLine());

            if (numberOfHumanPlayers == 1) 
            {
                playerTwo= new ComputerPlayer();
            }
            


        }

        public void CompareGestures()
        {

            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("Tie, No winner");
                return;
            }

            else if (
                (playerOne.chosenGesture == "Rock" && playerTwo.chosenGesture == Gesture.Scissor) ||
                (playerOne.chosenGesture == Gesture.Scissor && playerTwo.chosenGesture=Gesture.Paper)||
                (playerOne.chosenGesture == Gesture.Paper && playerTwo.chosenGesture ==Gesture.=Rock)||
                (playerOne.chosenGesture == Gesture.Rock && playerTwo.chosenGesture==Gesture.Lizard)||
                (playerOne.chosenGesture == Gesture.Lizard && playerTwo.chosenGesture==Gesture.Spock)||
                (playerOne.chosenGesture == Gesture.Spock && playerTwo.chosenGesture==Gesture.Scissor)||
                (playerOne.chosenGesture == Gesture.Lizard && playerTwo.chosenGesture==Gesture.Paper)||
                (playerOne.chosenGesture == Gesture.Paper && playerTwo.chosenGesture==Gesture.Gesture.Spock)||
                (playerOne.chosenGesture == Gesture.Spock && playerTwo.chosenGesture==Gesture.Rock)

                )
             {
                Console.WriteLine("Player Two wins");
                playerTwo score++
             }
                
            else
            {
                Console.WriteLine("Player one wins");
                playeOne score++;

            }    
        }

        public void DisplayGameWinner()
        {

        }

        public void RunGame()
        {
            WelcomeMessage();
            int numPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numPlayers);
        }
    }
}
