using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    public class Handelaar : ApplicationUser
    {
        private Zaak _zaak;
        protected Handelaar() { }
        public Handelaar(string naam, string voornaam, string emailadres, string wachtwoord, Adres adres, Zaak zaak)
        {
            Naam = naam;
            Voornaam = voornaam;
            Emailadres = emailadres;
            Adres = adres;
            _zaak = zaak;
        }

        public Zaak Zaak
        {
            get
            {
                return _zaak;
            }
        }
    }
}
