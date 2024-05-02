using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class FileManager: IManager  // klasa odpowiedzialana za zapisywanie danych do pliku
    {
        public void SaveLamp(Lamp lamp)
        {
            var path = "lamps.txt";
            var content = " Lampa" + "Wysokość-" + lamp.Height + " moc - " + lamp.Power;

            File.WriteAllText(path, content);
        }
            
    }
}
