using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST

{
    class Food : GameObject
    {
        public Food(Position newPosition)
        {
            position = newPosition;
            Apperance = 'o';
        }

        public override void Update() //an empty Update method
        {

        }
    }
}