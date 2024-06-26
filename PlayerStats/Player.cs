using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        // Variables
        private float highScore;
        private int playedGames;
        private int wonGames;

        // Property that manages the high score
        public float HighScore
        {
            // Returns current high score
            get { return highScore; }
            // Check if value is greater than current value
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }
        
        // Auto-implemented readonly property for the name
        public string Name {get;}
        
        // Readonly property that returns the win rate
        public float WinRate
        {
            get 
            {
                float tempRate;
                // Use if to avoid dividing by zero
                if (playedGames == 0) tempRate = 0;
                else tempRate = (float) wonGames/ playedGames;
                return tempRate;
            }
        }

        public void PlayGame(bool win)
        {
            // Increment games played
            playedGames++;
            // Increment games won if won
            if (win) wonGames++;
        }

        // Constructor
        public Player(string name)
        {
            Name = name;
            highScore = 0;
            playedGames = 0;
            wonGames = 0;
        }
    }
}