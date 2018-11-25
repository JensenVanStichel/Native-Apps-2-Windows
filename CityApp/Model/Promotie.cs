using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    public class Promotie
    {
        public int Id { get; set; }
        public DateTime? BeginDatum { get; set; }
        public DateTime? EindDatum { get; set; }
        public string Titel { get; set; }
        public string Beschrijving { get; set; }

        protected Promotie() { }

        public Promotie(DateTime? beginDatum, DateTime? eindDatum, string titel, string beschrijving)
        {
            BeginDatum = beginDatum;
            EindDatum = eindDatum;
            Titel = titel;
            Beschrijving = beschrijving;
        }

        public void VerlengPromotie(DateTime eindDatum)
        {
            if(eindDatum > EindDatum)
            {
                EindDatum = eindDatum;
            } else
            {
                throw new Exception("De nieuwe datum moet na de oude datum liggen");
            }
        }
    }
}
