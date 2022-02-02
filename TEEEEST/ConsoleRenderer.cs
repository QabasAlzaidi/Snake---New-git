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



            // Console-fönstret enligt världens storlek --- Skapa Mapp strukturen åt er :) 
           Console.SetWindowSize(70, 50);


            world = gameWorld;
        }

        public void Render()
        {
            // TODO Rendera spelvärlden (och poängräkningen)

            // Använd Console.SetCursorPosition(int x, int y) and Console.Write(char)

            //Console.Clear();

                Console.SetCursorPosition(world.GameObjects[0].position.X, world.GameObjects[0].position.Y);
                Console.Write(world.GameObjects[0].Apperance);
          

            /*
            for (int i = 0; i <= (world.Bredd + 2); i++)
            {
                Console.SetCursorPosition(i, 1);
                Console.Write("_");
            }
            for (int i = 0; i <= (Bredd + 2); i++)
            {
                Console.SetCursorPosition(i, (Höjd + 2));
                Console.Write("_");
            }
            for (int i = 0; i <= (Höjd + 1); i++)
            {
                Console.SetCursorPosition(1, i);
                Console.Write("|");
            }
            for (int i = 0; i <= (Höjd + 1); i++)
            {
                Console.SetCursorPosition((Bredd + 2), i);
                Console.Write("|");
            }
            */
        }
    }
}