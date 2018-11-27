using Backend_app.Models;
using Backend_app.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend_app.Controllers.Repositories
{
    public class HandelaarRepository : IHandelaarRepository
    {
        public IEnumerable<Handelaar> AlleHandelaars()
        {
            throw new NotImplementedException();
        }

        public Handelaar GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Handelaar MaakHandelaar(Handelaar handelaar)
        {
            throw new NotImplementedException();
        }

        public Handelaar UpdateHandelaar(int id, Handelaar handelaar)
        {
            throw new NotImplementedException();
        }

        public bool VerwijderHandelaar(int id)
        {
            throw new NotImplementedException();
        }
    }
}