using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    class ApplicationUser
    {
        public String Naam { get; set; }
        public Adres Adres {get;set;}

        public ApplicationUser(string naam) {
            Naam = naam;
        }

        protected ApplicationUser() { }
    }
}
