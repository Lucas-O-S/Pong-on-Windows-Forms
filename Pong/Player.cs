using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    //Players class
    class Player
    {
        //How many points
        private int Points = 0;

        //Player velocity, always return 10 px
        public int Velocity => 10;

        //add 1 point to the player
        public void AddPoint()
        {
            Points++;
        }

        //Return how many points the player have
        public int GetPoints()
        {
            return Points;
        }


    }
}
