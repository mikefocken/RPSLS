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
                Console.WriteLine(" Do you remember playing Rock,Paper,Scissors as a kid?..... Well,we made it better by introducing a few more gestures:\n");
                Console.WriteLine(" Rock smashes scissors,scissors cuts paper, paper covers rock,rock smashes lizard");
                Console.WriteLine(" lizard poisons Spock, Spock smashes scissors, scissors decapitates lizard,Lizard eats paper....Did you get all that?:\n");
                Console.WriteLine("The game will play until one player wins the best of three games!:\n");
                Console.WriteLine("If you don't have a friend to play the game with, you can play against the computer. ");
                
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
            Console.WriteLine("What is Player Two's name?");
          

            if (numberOfHumanPlayers == 1)
            {
                playerTwo= new ComputerPlayer();
            }

            else
            {
              playerTwo = new HumanPlayer(Console.ReadLine());
            }

        }

        public void CompareGestures()
        {
            playerOne.ChooseGesture();
            playerTwo.ChooseGesture();

            Console.WriteLine($"Player One Chose: {playerOne.chosenGesture}");
            Console.WriteLine($"Player Two Chose: {playerTwo.chosenGesture}");

            if (playerOne.chosenGesture == playerTwo.chosenGesture)
            {
                Console.WriteLine("Tie, No winner");
                return;
            }
            else if (
                (playerOne.chosenGesture == "Rock" && (playerTwo.chosenGesture == "Scissor" || playerTwo.chosenGesture == "Lizard")) ||
                (playerOne.chosenGesture == "Scissor" && (playerTwo.chosenGesture == "Paper" || playerTwo.chosenGesture == "Lizard")) ||
                (playerOne.chosenGesture == "Paper" && (playerTwo.chosenGesture == "Rock" || playerTwo.chosenGesture == "Spock")) ||
                (playerOne.chosenGesture == "Lizard" && (playerTwo.chosenGesture == "Spock" || playerTwo.chosenGesture == "Paper")) ||
                (playerOne.chosenGesture == "Spock" && (playerTwo.chosenGesture == "Scissor" || playerTwo.chosenGesture == "Rock"))
            )
            {
                Console.WriteLine("Player One wins");
                playerOne.score++;
            }
            else
            {
                Console.WriteLine("Player Two wins");
                playerTwo.score++;
            }

            
        }   
        public void DisplayGameWinner()
            {
                if (playerOne.score >= 2)
                {
                    Console.WriteLine($"Congratulations!{playerOne} You're are the winner");
                }
                else if (playerTwo.score >=2)
                {
                    Console.WriteLine($"Congratulations!{playerTwo} You're the Winner");
                }
                else
                {
                    Console.WriteLine("Please continue, no one has one yet");
                }

        }

        public void RunGame()
        { 
        
            WelcomeMessage();
            int numPlayers = ChooseNumberOfHumanPlayers();
            CreatePlayerObjects(numPlayers);

            while (playerOne.score < 2 && playerTwo.score < 2)
            {
                CompareGestures();
            }

            DisplayGameWinner();
            
            
        }
    }

}
            
                
    














      

  
