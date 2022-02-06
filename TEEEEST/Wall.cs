using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST
{
    internal class Wall : GameObject
    {
        public int WallNumber { get; set; }

        public Wall(Position wallPosition)
        {
            position = wallPosition;
            Apperance = '|';
        }

        public override void Update()
        {

        }
    }
}
