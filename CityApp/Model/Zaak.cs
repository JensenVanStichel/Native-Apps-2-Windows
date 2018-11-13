using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    class Zaak
    {
        public Type Type { get; set; }
        public Adres Adres { get; set; }
        public ICollection<Categorie> Categorieen { get; set; }
        public ICollection<Event> Events { get; set; }
        public ICollection<Image> Images { get; set; }
        public ICollection<Promotie> Promoties { get; set; }

        protected Zaak() { }

        public Zaak(Type type, Adres adres, ICollection<Categorie> categorieen, ICollection<Event> events, ICollection<Image> images, ICollection<Promotie> promoties)
        {
            Type = type;
            Adres = adres;
            Categorieen = categorieen;
            Events = events;
            Images = images;
            Promoties = promoties;
        }
    }
}
