using Backend_app.Models;
using Backend_app.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend_app.Controllers.Repositories
{
    public class GebruikerRepository : IGebruikerRepository
    {
        public IEnumerable<Gebruiker> AlleGebruikers()
        {
            throw new NotImplementedException();
        }

        public Gebruiker GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Gebruiker NieuweGebruiker(Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }

        public Gebruiker UpdateGebruiker(int id, Gebruiker gebruiker)
        {
            throw new NotImplementedException();
        }

        public bool VerwijderGebruiker(int id)
        {
            throw new NotImplementedException();
        }
    }
}