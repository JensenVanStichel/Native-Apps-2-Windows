using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_app.Models
{
    public class Zaak
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public Type Type { get; set; }
        public Adres Adres { get; set; }
        private ICollection<Categorie> _categorieen;
        private ICollection<Event> _events;
        private ICollection<Image> _images;
        private ICollection<Promotie> _promoties;

        protected Zaak() { }

        public Zaak(Type type, Adres adres, ICollection<Categorie> categorieen, ICollection<Event> events, ICollection<Image> images, ICollection<Promotie> promoties)
        {
            Type = type;
            Adres = adres;
            _categorieen = categorieen;
            _events = events;
            _images = images;
            _promoties = promoties;
        }

        public ICollection<Categorie> Categorieen
        {
            get
            {
                return _categorieen;
            }
        }

        public void VoegCategorieToe(Categorie categorie)
        {
            _categorieen.Add(categorie);
        }

        public ICollection<Event> Events
        {
            get
            {
                return _events;
            }
        }

        public void VoegEventToe(Event nieuwEvent)
        {
            _events.Add(nieuwEvent);
        }

        public ICollection<Image> Images
        {
            get
            {
                return _images;
            }
        }

        public void VoegImageToe(Image image)
        {
            _images.Add(image);
        }

        public ICollection<Promotie> Promoties
        {
            get
            {
                return _promoties;
            }
        }

        public void VoegPromotieToe(Promotie promotie)
        {
            _promoties.Add(promotie);
        }
    }
}
