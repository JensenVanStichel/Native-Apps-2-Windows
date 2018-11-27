using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend_app.Models.Interfaces
{
    public interface IGebruikerRepository
    {
        Gebruiker NieuweGebruiker(Gebruiker gebruiker);
        IEnumerable<Gebruiker> AlleGebruikers();
        Gebruiker GetById(int id);
        Gebruiker UpdateGebruiker(int id, Gebruiker gebruiker);
        bool VerwijderGebruiker(int id);
    }
}