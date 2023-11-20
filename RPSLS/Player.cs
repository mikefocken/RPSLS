﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    internal abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public List<string> gestures;
        public string chosenGesture;
        public int score;

        //Constructor
        public Player (string name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }
        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player 
             
                  
    }

    internal class HumanPlayer : Player
    {
       
        public HumanPlayer (string playerone, string playertwo, string chosenGesture)

        {
            this.name=name;
            this.gestures= new List<string>();
            this.pickGesture=chosenGesture;
        }

        public void pickGesture()

        {

            Console.WriteLine($"Please choose a gesture{List}.");

        }










    }
}
