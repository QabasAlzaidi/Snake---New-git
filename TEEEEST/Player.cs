﻿using System;
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
       // asddffghjjyfhzjtykhjhfd
        private Direction playerD; 

        private string playerDirection = "";

        public Player()
        {
            Position startPostion = new Position{ X = 10, Y = 10 };

            position = startPostion;      
            Apperance = 'S';
            playerD = Direction.upp; // add all other directions 

            playerDirection = "Right";


        }

        public void SetDirection(Direction direction)
        {
            playerD = direction;
        }

      
        public override void Update()
        {
            //if (playerD == Direction.upp)
            //{
            //    position.Y -= 1;
            //}
            //if(playerDirection == "upp")
            //{
            //    position.Y -= 1;
            //}
        }
    }
}