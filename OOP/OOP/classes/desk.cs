using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Desk : Item
    {
       
        private int Widht { get; set; }

        public Desk(int height, int widht) // konstruktor, ZAWSZE PUBLIC
        {
            Height = height;
            Widht = widht;
        }
    }
}

