using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    public abstract class ApplicationUser
    {

        public String Naam { get; set; }
        public Adres Adres { get; set; }
        public string Emailadres { get; set; }
        public string Wachtwoord { get; set; }

        protected ApplicationUser() { }
    }
}
