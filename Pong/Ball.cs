using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    //Class that makes the ball work
    class Ball
    {
        //Velocity in X and Y of the ball
        // private version that only Ball can chage
        private int _XVelocity = 5 , _YVelocity = 5;

        //Public versions that anyone can only get
        public int XVelocity => _XVelocity;
        public int YVelocity => _YVelocity;

        //BaseVelocity is the base to calculate the velocity with Variation
        //Count count how many time the ball touches the players
        private int BaseVelocity = 5, count = 0;

        //Variation is a ramdom number that sums with the velocity
        Random Variation = new Random();



        //Change the movement of the ball in Y axis
        public void InvertY()
        {
            //Gets a new positive(downward) value for Y velocity
            if (YVelocity >= 0)
            {
                //Call ChangeYVelocity to change the value of the Y velocity
                _YVelocity = ChangeVY();
            }

            //Gets a new negative(upward) value for Y velocity
            else
            {
                //Call ChangeYVelocity to change the value of the Y velocity to make the ball go upwards
                _YVelocity = -ChangeVY();

            }
            //Invert the movement direction to the oposite 
            _YVelocity = -YVelocity;
        }

        //The same of Y velocity but now with X axis so instead of up and down is left(negative) and right(positive)
        public void InvertX()
        {
            if (XVelocity >= 0)
            {
                _XVelocity = ChangeVX();
            }
            else
            {
                _XVelocity = -ChangeVX();

            }

            _XVelocity = -XVelocity;
        }

       

        //Return a new velocity using the base plus variation
        public int ChangeVY()
        {
            return BaseVelocity + Variation.Next(-4, 5);
        }

        public int ChangeVX()
        {
            return BaseVelocity + Variation.Next(-2, 5);
        }


        //After the ball touches the player the same amount of the base velocity it sum 1 more on them
        public void Acellerate()
        {

            if (count == BaseVelocity)
            {
                //base velocity get one px faster
                BaseVelocity++;

                //Reset count to
                count = 0;
            }

            count++;
        }

        //Reset values
        public void ResetBase()
        {
            BaseVelocity = 5;
            count = 0;

        }
    }
}
