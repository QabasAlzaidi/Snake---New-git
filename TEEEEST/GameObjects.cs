using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST
{
    //Skapa en abstrakt klass GameObject med en variabel "position" (av typen Position från ovan)
    //samt en char-variabel "appearance" för dess utseende (vilket tecken som ska skrivas ut på skärmen för den).
    //Ge också klassen en abstrakt void-metod Update().
    internal abstract class GameObject
    {
        // TODO

        public Position position;
        public char Apperance;
        public Player player;
        public GameWorld world;


        public GameObject(GameWorld world)
        {
            // random position och andra object utifrån ganeworlds storleken
            world = world;
            position = new Position(randomStart(world.Höjd), randomStart(world.Bredd));
        }

        protected GameObject()
        {
        }

        public abstract void Update();

        // random antal position
        public int randomStart(int max)
        {
            Random r = new Random();
            return r.Next(max + 1);
        }

        public void ControlPosition()// kontrollerar ormen och matten position , att inte går ut ur kanten
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
                position.Y = 19;
            }
        }
    }
}