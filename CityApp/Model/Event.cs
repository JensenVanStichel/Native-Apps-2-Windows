﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityApp.Model
{
    class Event
    {
        public string Naam { get; set; }
        public DateTime BeginDatum { get; set; }
        public DateTime EindDatum { get; set; }

        protected Event() { }

        public Event(string naam, DateTime beginDatum, DateTime eindDatum)
        {
            Naam = naam;
            BeginDatum = beginDatum;
            EindDatum = eindDatum;
        }

    }
}
