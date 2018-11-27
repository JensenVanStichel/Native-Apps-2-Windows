using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Backend_app.Models;
using Backend_app.Models.Interfaces;

namespace Backend_app.Controllers.Repositories
{
    public class CategorieRepository : ICategorieRepository
    {
        //geen DbSets? 
        public IEnumerable<Categorie> AlleCategorieen()
        {
            throw new NotImplementedException();
        }

        public Categorie GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Categorie NieuweCategorie(Categorie categorie)
        {
            throw new NotImplementedException();
        }
    }
}