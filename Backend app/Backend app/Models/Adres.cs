using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_app.Models
{
    public class Adres
    {
        public int Id { get; set; }
        public int Huisnummer { get; set; }
        public string Toevoeging { get; set; }
        public string Straatnaam { get; set; }
        public int Postcode { get; set; }
        public string Stadsnaam { get; set; }
        public Provincie Provincie { get; set; }

        protected Adres() { }

        public Adres(int huisnummer, string toevoeging, string straatnaam, int postcode, string stadsnaam, Provincie provincie)
        {
            Huisnummer = huisnummer;
            Toevoeging = toevoeging;
            Straatnaam = straatnaam;
            Postcode = postcode;
            Stadsnaam = stadsnaam;
            Provincie = provincie;
        }

    }

}
