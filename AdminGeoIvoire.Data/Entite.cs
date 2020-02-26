using System;

namespace AdminGeoIvoire.Data
{
    public class Entite : IEntite
    {
        public string  Createur { get; set; }

        public DateTime? DateCreation { get; set; }

        public string  DernierModificateur { get; set; }

        public DateTime? DateDerniereModification { get; set; }

        public bool Actif { get; set; }
    }
}