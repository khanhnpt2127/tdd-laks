using System;
using System.Collections.Generic;
using System.Text;

namespace bowlingApp
{
    public class Game
    {
        private int _score;
        public void Roll(int pins)
        {
            _score += pins;
        }

        public int Score(int i)
        {
            return _score;
        }
    }
}
