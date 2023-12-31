﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
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
            gestures = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }
        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player 
        public abstract void ChooseGesture();       
               
    }
   
}
