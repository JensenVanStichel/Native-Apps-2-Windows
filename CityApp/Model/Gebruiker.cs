using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    public class Gebruiker : ApplicationUser
    {
        public ICollection<Notificatie> _notificaties;

        protected Gebruiker()
        {

        }
        
        public Gebruiker(string naam, string voornaam, string emailadres, string wachtwoord, Adres adres)
        {
            Naam = naam;
            Voornaam = voornaam;
            Emailadres = emailadres;
            Wachtwoord = wachtwoord;
            Adres = adres;
            _notificaties = new List<Notificatie>();
        }

        public ICollection<Notificatie> Notificaties
        {
            get
            {
                return _notificaties;
            }
        }

        public void VoegNotificatieToe(Notificatie notificatie)
        {
            _notificaties.Add(notificatie);
        }
        
    }

}
