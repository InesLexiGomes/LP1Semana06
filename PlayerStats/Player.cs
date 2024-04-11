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
        private int wonGames

        // Property that manages the high score
        public float highScore
        {
            // Returns current high score
            get { return highScore; }
            // Check if value is greater than current value
            private set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }
    }
}