using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    class Handelaar: ApplicationUser
    {
        public Zaak Zaak { get; set; }

        protected Handelaar() { }

        public Handelaar(string naam, Adres adres)
        {
            Naam = naam;
            Adres = adres;
        }
    }
}
