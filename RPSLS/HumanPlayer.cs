using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string name) : base(name) 
        {         
        }

        public override void ChooseGesture()
        {
          Console.WriteLine($"Please choose a gesture.");
          Console.WriteLine("\nEnter:");
          Console.WriteLine(" 0 for Rock");
          Console.WriteLine(" 1 for Paper");
          Console.WriteLine(" 2 for Scissors");
          Console.WriteLine(" 3 for Lizard");
          Console.WriteLine(" 4 for Spock");

            int index = int.Parse(Console.ReadLine());
            chosenGesture =gestures[index];
        }
    }    
        
        
}   
