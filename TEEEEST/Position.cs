using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST
{
    /// <summary>
    /// This class creates the X and Y, which are the position in our program game.
    /// The X and Y determines the positions of all our objects.
    /// </summary>

    internal class Position
    {
        public int X;
        public int Y;


        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}