using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    class Gebruiker: ApplicationUser
    {
        public ICollection<Notificatie> Notificaties { get; set; }
    }

}
