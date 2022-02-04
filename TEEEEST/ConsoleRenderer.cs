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


            Console.SetCursorPosition(world.GameObjects[0].position.X, world.GameObjects[0].position.Y);
            Console.Write(world.GameObjects[0].Apperance);



            //for (int i = 0; i <= (world.Bredd + 1); i++)
            //{
            //    Console.SetCursorPosition(i, 1);
            //    Console.Write("_");
            //}
            //for (int i = 0; i <= (world.Bredd + 1); i++)
            //{
            //    Console.SetCursorPosition(i, (world.Höjd + 1));
            //    Console.Write("_");
            //}
            //for (int i = 0; i <= (world.Höjd + 1); i++)
            //{
            //    Console.SetCursorPosition(1, i);
            //    Console.Write("|");
            //}
            //for (int i = 0; i <= (world.Höjd +1); i++)
            //{
            //    Console.SetCursorPosition((world.Bredd + 1), i);
            //    Console.Write("|");
            //}

        }
        public void RenderBlank()
        {
            Console.SetCursorPosition(world.GameObjects[0].position.X, world.GameObjects[0].position.Y);
            Console.Write(" ");
        }
    }
}