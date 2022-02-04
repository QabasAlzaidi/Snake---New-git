using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST
{
    //Uppdatera slutligen koden för spelvärlden (GameWorld) med variabler för hur stor spelvärlden är (Bredd och Höjd),
    //ett int-fält för antalet poäng, och en List<GameObject> som ska innehålla alla objekt i spelet.
    //Ge den en passande konstruktor.
    //Denna klass ska också ha en publik Update() metod - denna ska loopa igenom ovanstående lista och anropa Update() för varje objekt.

    internal class GameWorld
    {
        public int Bredd { get; set; }
        public int Höjd { get; set; }
        public int poäng { get; set; }


        public List<GameObject> GameObjects = new List<GameObject>();
        public GameWorld()
        {
            Bredd = 50;
            Höjd = 20;
            poäng = 0;

            GameObjects = new List<GameObject>();
        }

        public void Update()
        {
            // TODO
            foreach (var obj in GameObjects)// en loop som kontrollerar mat position och orms position att de inte krockas
            {
                obj.Update();
            }
            Position playerPosition = new Position(0, 0);
            Position foodPosition = new Position(0, 0);

            int foodIndex = 0;


            for (int i = 0; i < GameObjects.Count; i++)
            {
                if (GameObjects[i] is Player)
                {
                    if (GameObjects[i].position.X >= 49)
                    {
                        GameObjects[i].position.X = 0;
                    }
                    else if (GameObjects[i].position.X <= 1)
                    {
                        GameObjects[i].position.X = 49;
                    }
                    else if (GameObjects[i].position.Y >= 49)
                    {
                        GameObjects[i].position.Y = 0;
                    }
                    else if (GameObjects[i].position.Y <= 1)
                    {
                        GameObjects[i].position.Y = 0;
                    }
                    playerPosition = GameObjects[i].position;
                }
                else if (GameObjects[i] is Food)
                {
                    foodIndex = i;
                    foodPosition = GameObjects[i].position;
                }


            }
            if (playerPosition == foodPosition)
            {
                poäng++;
                GameObjects.RemoveAt(foodIndex);
                GameObjects.Add(CreatFood());

            }



        }
        public Food CreatFood()
        {
            Random r = new Random();

            int x = r.Next(2, 28);
            int y = r.Next(2, 10);
            Food feed = new Food(new Position(x, y));
            return feed;

        }





        public void AddGameObject(GameObject gameObject)
        {
            GameObjects.Add(gameObject);
        }



    }
}