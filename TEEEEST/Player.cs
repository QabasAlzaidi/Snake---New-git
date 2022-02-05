using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST
{
    internal class Player : GameObject

    {//Skapa klassen Player som ärver från GameObject.
     //Ge den en ordentlig konstruktor och en variabel som håller reda på spelarens riktning (upp, ner, vänster, höger - det kan vara en sträng eller en enum).
     //Implementera metoden Update() så att den, beroende på spelarens riktning,
     //flyttar sin position ett steg i rätt riktning.
        public enum Direction
        {
            upp, ner, höger, vänster
        }

        public Direction playerD;

        public Player () //to create an object  without parameters 
        {

        }
        public Player(Position newPosition)
        {
            position = newPosition;
            Apperance = '$';
            playerD = Direction.upp;
        }
        public void SetDirection(Direction direction)
        {
            playerD = direction;
        }
        public void ControlPosition()// kontrollerar ormens position , att inte går ut ur kanten
        {
            if (position.X > 49)// äntligen lyckades jag med en sak till i kväll =)
            {
                position.X = 0;
            }
            else if (position.Y > 19)
            {
                position.Y = 0;
            }
            else if (position.X < 0)
            {
                position.X = 49;
            }
            else if (position.Y < 0)
            {
                System.Diagnostics.Debug.WriteLine("player class LINE 47 position x " + position.X + " position y " + position.Y);
                position.Y = 19;
            }
        }
        public override void Update()
        {
            if (playerD == Direction.upp)
            {
                position.Y -= 1;
               // Console.SetCursorPosition(50, 20);
                System.Diagnostics.Debug.WriteLine("Player class LINE 59 position x " + position.X + " position y " + position.Y);
                ControlPosition();
            }
            else if (playerD == Direction.ner)
            {
                position.Y += 1;
                //Console.SetCursorPosition(50, 20);
                ControlPosition();
            }
            else if (playerD == Direction.vänster)
            {
                position.X -= 1;
                //Console.SetCursorPosition(50, 20);
                System.Diagnostics.Debug.WriteLine("Player class LINE 85 position x " + position.X + " position y " + position.Y);
                ControlPosition();
            }
            else if (playerD == Direction.höger)
            {
                position.X += 1;
                //Console.SetCursorPosition(50, 20);
                ControlPosition();
            }
        }
    }
}