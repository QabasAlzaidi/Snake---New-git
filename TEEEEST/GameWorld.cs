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
            Position wallOnePosition = new Position(0, 0);
            Position wallTwoPosition = new Position(0, 0);

            int foodIndex = 0;
            int wallIndex = 0;

            //GameObjects.RemoveAt(1);
            

            for (int i = 0; i < GameObjects.Count; i++)
            {
                if (GameObjects[i] is Player)
                {
                    playerPosition = GameObjects[i].position;
                }
                else if (GameObjects[i] is Food)
                    {
                        foodPosition = GameObjects[i].position;
                        foodIndex = i;
                    }
                else if (GameObjects[i] is Wall)
                {
                   Wall firstWall = (Wall)GameObjects[i];
                   Wall secondWall = (Wall)GameObjects[i];

                    if (firstWall.WallNumber == 1)
                    {
                        wallOnePosition = GameObjects[i].position;  
                    }

                   else if (secondWall.WallNumber == 2)
                   {
                        wallTwoPosition = GameObjects[i].position;  
                   }
                    
                wallIndex = i;
                }
                
            }


            //for (int i = 0; i < GameObjects.Count; i++)
            //{
            //    if (GameObjects[i] is Player)
            //    {
            //        if (GameObjects[i].position.X > 49)
            //        {
            //            GameObjects[i].position.X = 0;
            //        }
            //        else if (GameObjects[i].position.X < 1)
            //        {
            //            GameObjects[i].position.X += 1;
            //        }
            //        else if (GameObjects[i].position.Y > 19)
            //        {
            //            GameObjects[i].position.Y += 19;
            //        }
            //        else if (GameObjects[i].position.Y < 1)
            //        {
            //            GameObjects[i].position.Y -= 0;
            //        }
            //        playerPosition = GameObjects[i].position;
            //    }
            //    else if (GameObjects[i] is Food)
            //    {
            //        foodIndex = i;
            //        foodPosition = GameObjects[i].position;
            //    }
            //    else if (playerPosition == wallPosition) // if the snake eats the food, increase the score and change food position
            //    {

            //        Console.WriteLine("You died, and you score is: " + poäng + "Game over!! :(");
            //    }

            //}

            System.Diagnostics.Debug.WriteLine("Game world class lINE 81 " + playerPosition.X + " px " + foodPosition.X + " fx " + playerPosition.Y + " py " + foodPosition.Y + " fy " );

            if (playerPosition.X == foodPosition.X  && playerPosition.Y == foodPosition.Y) // if the snake eats the food, increase the score and change food position
            {
                poäng++;
                GameObjects.RemoveAt(foodIndex);
                GameObjects.Add(CreatFood());
            }
            
            if ((playerPosition.X == wallOnePosition.X && playerPosition.Y == wallOnePosition.Y) || (playerPosition.X == wallTwoPosition.X && playerPosition.Y == wallTwoPosition.Y)) // if the snake hits the wall, its game over
            {
                throw new SystemException("Wall crash!");
                //clearGameList();
                Console.WriteLine("Opps you died,  Game over!! :( ");
            }

        }



        private void clearGameList() 
        {
            for (int i = GameObjects.Count - 1; i > 0; i--)
            {
                GameObjects.RemoveAt(i);
            }

        }

        public Food CreatFood()
        {
            Random r = new Random();

            int x = r.Next(12, 31);
            int y = r.Next(5, 10);
            Food feed = new Food(new Position(x, y));
            return feed;

            //while (x == Wall.position.x && y == Wall.position.Y)
            //{

            //}

        }


        public void AddGameObject(GameObject gameObject)
        {
            GameObjects.Add(gameObject);
        }



    }
}