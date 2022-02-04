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
        public int Bredd;
        public int Höjd;
        public int poäng;


        public List<GameObject> GameObjects;

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
                //    if (obj is mattbiten) // när vi skappar mattbiten !!!!!
                //    {
                //        GameObjects.Remove(matbitten);
                //        GameObjects.Add(obj); 
                //        poäng++;    
                //        Console.Write(poäng); obs inte saker om den ska skrivas här eller på program.cs!!
                //    } 
            }
            //if (!matbien)
            //    Console.Write("0");
        }

        public void AddGameObject(GameObject gameObject)
        {
            GameObjects.Add(gameObject);
        }



    }
}