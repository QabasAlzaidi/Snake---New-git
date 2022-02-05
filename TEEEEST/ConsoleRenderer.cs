using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST
{  //sensible size (eg 50x20).
    internal class ConsoleRenderer
    {
        private GameWorld world;

        public ConsoleRenderer(GameWorld gameWorld)
        {
            // TODO Konfigurera

            Console.CursorVisible = false;
            // Console-fönstret enligt världens storlek --- Skapa Mapp strukturen åt er :) 
            Console.SetWindowSize(50, 20);

            world = gameWorld;
        }

        public void Render()
        {
            foreach (var gameObject in world.GameObjects)
            {
                Console.SetCursorPosition(gameObject.position.X, gameObject.position.Y);
                Console.Write(gameObject.Apperance);
            }
            
            //for (int i = 0; i <= 1; i++) // to create an obsticle (walls) 
            //{
            //    Console.SetCursorPosition(4, 28);
            //    Console.Write("|");
            //}
            
            //for (int i = 0; i <= 1; i++) // to create an obsticle (walls) 
            //{
            //    Console.SetCursorPosition(35, 10);
            //    Console.Write("|");
            //}

            for (int i = 0; i <= 1; i++) // score
            {
                Console.SetCursorPosition(0, 0);
                Console.Write("Score: " + world.poäng);
            }


            //for (int i = 0; i <= (world.Höjd +1); i++)
            //{
            //    Console.SetCursorPosition((world.Bredd + 1), i);
            //    Console.Write("|");
            //}
        }
        public void RenderBlank()
        {
            foreach (var gameObject in world.GameObjects)
            {
                Console.SetCursorPosition(gameObject.position.X, gameObject.position.Y);
                Console.Write(" ");
            }
        }
    }
}