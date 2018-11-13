using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    public class Notificatie
    {
        public string Titel { get; set; }
        public string Beschrijving { get; set; }
        public Image Image { get; set; }

        protected Notificatie() { }

        public Notificatie(string titel, string beschrijving)
        {
            Titel = titel;
            Beschrijving = beschrijving;
        }

        public Notificatie(string titel, string beschrijving, Image image)
        {
            Titel = titel;
            Beschrijving = beschrijving;
            Image = image;
        }

    }
}
