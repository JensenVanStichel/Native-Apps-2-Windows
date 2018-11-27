using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend_app.Models
{
    public abstract class ApplicationUser
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Voornaam { get; set; }
        public string Emailadres { get; set; }
        public string Wachtwoord { get; set; }
        public Adres Adres { get; set; }

        protected ApplicationUser() { }
    }
}
