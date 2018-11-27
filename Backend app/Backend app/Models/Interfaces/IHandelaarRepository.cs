using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend_app.Models.Interfaces
{
    public interface IHandelaarRepository
    {
        Handelaar MaakHandelaar(Handelaar handelaar);
        IEnumerable<Handelaar> AlleHandelaars();
        Handelaar GetById(int id);
        Handelaar UpdateHandelaar(int id, Handelaar handelaar);
        bool VerwijderHandelaar(int id);
    }
}