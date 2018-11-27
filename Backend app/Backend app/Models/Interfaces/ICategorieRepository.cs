using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend_app.Models.Interfaces
{
    public interface ICategorieRepository
    {
        IEnumerable<Categorie> AlleCategorieen();
        Categorie GetById(int id);
        Categorie NieuweCategorie(Categorie categorie);
    }
}