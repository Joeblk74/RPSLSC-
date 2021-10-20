using System;

namespace RPSLP
{
    class Program
    {
        static void Main(string[] args)
        {
            Player playerOne = new Player();
            playerOne.name = " ";
            playerOne.gestures[]= { "rock", "paper", "scissors", "lizard", "spock" };
            gestures[0] = "rock";
            gestures[1] = "paper";
            gestures[2] = "scissors";
            gestures[3] = "lizard";
            gestures[4] = "spock";
            
            foreach (int gesture in gestures)
            {
                Console.WriteLine(gesture)
            }
            playerOne.chosenGesture = "";
            playerOne.score = ' ';

            
        }
    }
}
