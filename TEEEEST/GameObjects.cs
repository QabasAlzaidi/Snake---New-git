using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST
{

    internal abstract class GameObject
    {

        /// <summary>
        /// This class creates the objects like position, the charecter or the apperance of the snake, food, and wall.
        /// </summary>

        public Position position;
        public char Apperance;
        public Wall wall;
        public ConsoleColor color = ConsoleColor.Blue;


        public abstract void Update();

    }
}