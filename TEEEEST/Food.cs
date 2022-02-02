using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEEEEST
{
    internal class Food : GameObject 
    {
        int mapWidht;
        int mapHeight;
        char sym;

        Random random = new Random();

        public Food(int mapWidht, int mapHeight, char sym)
        {
            this.mapWidht = mapWidht;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }


        public override void Update()
        {
            int x = random.Next(2, mapWidht - 2); // creating food 
            int y = random.Next(2, mapHeight - 2);
            return new Point(x, y, sym);
        }
}