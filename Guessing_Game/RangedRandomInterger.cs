//Son Tran April 1st 2022

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class RangedRandomInterger : RandomInteger
    {
        private int maximum = 10;
        private int minimum = 1;

        public RangedRandomInterger()
        {

        }

        public RangedRandomInterger(int minimun, int maximum)
        {

        }

        //methods
        public new int GenerateRandomNumber()
        {
            return random.Next(this.minimum, this.maximum); //TODO: Need to update this
        }

        //set methods
        public void  SetMinimum ( int minimum )
        {
            if (minimum < 0) this.minimum = 0;
            this.minimum = minimum;
        }
        public void SetMaximum ( int maximum )
        {
            if (maximum > this.minimum) this.maximum = maximum;
        }

        //get methods
        public int GetMinimum() { return minimum; }
        public int GetMaximum() { return maximum; }
    }
}
