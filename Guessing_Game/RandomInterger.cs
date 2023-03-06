//Son Tran April 1st 2022
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class RandomInteger
    {
        protected Random random = new(int.Parse(Guid.NewGuid().ToString()[..8], System.Globalization.NumberStyles.HexNumber));
        protected int currentRandomNumber = 0;

        public RandomInteger()
        {

        }

        public int GenerateRandomNumber()
        {
            currentRandomNumber = random.Next();
            return currentRandomNumber;
        }

        public int GetCurrentRandomNumber() { return currentRandomNumber; }

    }
}
