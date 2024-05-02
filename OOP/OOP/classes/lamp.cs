using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Lamp : Item 
    {
       // private int Height { get; set; } // właściwość wysokość (właściwości obiektu Lamp, lamp to obiekt,
                                        // stwoprzyliśmy klasę obiektu, czyli przepis na obiekt
        public int Power { get; private set; } // właściwość moc

        // co może robić, czyli funkkcja lampy
        public void LightItself()
        {
            Console.WriteLine(Height);
            Console.WriteLine(Power);
        }
        public Lamp(int height, int power) // konstruktor, ZAWSZE PUBLIC
        {
            Height = height;
            Power = power;
        }
    }
}
