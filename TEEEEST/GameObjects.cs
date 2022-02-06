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
        public Wall wall;
        

        public abstract void Update();

    }
}