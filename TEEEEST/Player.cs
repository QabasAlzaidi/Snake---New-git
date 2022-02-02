using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST{
    internal class Player : GameObject

    {//Skapa klassen Player som ärver från GameObject.
     //Ge den en ordentlig konstruktor och en variabel som håller reda på spelarens riktning (upp, ner, vänster, höger - det kan vara en sträng eller en enum).
     //Implementera metoden Update() så att den, beroende på spelarens riktning,
     //flyttar sin position ett steg i rätt riktning.
        public enum Direction
        {
            upp, ner, höger, vänster
        }
       
        private Direction playerD; 

        private string playerDirection = "";

        public Player()
        {
            Position startPostion = new Position{ X = 35, Y = 25 };
          

            position = startPostion;      
            Apperance = '$';
            playerD = Direction.upp; // add all other directions 

            playerDirection = "right";

            protected List<GameObject> plist;

        //public void Draw()
        //{
        //    foreach (GameObject p in plist)
        //    {
        //        p.Draw();
        //    }
        //}

        //private bool IsHit(GameObject point)
        //{
        //    foreach (var p in plist)
        //    {
        //        if (p.IsHit(point))
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}
        //public bool IsHit(GameObject p)
        //{
        //    return p.x == this.x && p.y == this.y;
        //}
       

    }

        public void SetDirection(Direction direction)
        {
            playerD = direction;
        }

      
        public override void Update(int offset, Direction direction)
        {

        if (direction == Direction.RIGHT)
        {
            x = x + offset;
        }
        else if (direction == Direction.LEFT)
        {
            x = x - offset;
        }
        else if (direction == Direction.UP)
        {
            y = y - offset;
        }
        else if (direction == Direction.DOWN)
        {
            y = y + offset;
        }
    
    //Console.SetCursorPosition(X, Y);
    //Console.Write(Apperance);

    //if (playerD == Direction.upp)
    //{
    //    position.Y -= 1;
    //}
    //if(playerDirection == "upp")data:image/pjpeg;base64,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
    //{
    //    position.Y -= 1;
    //}
}
    }
}