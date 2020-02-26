using System;

namespace AdminGeoIvoire.Data.Dbo
{
    public class LogChange
    {
        public LogChange()
        {
        }

        public int? ID { get; set; }

        public string  NomClasse { get; set; }

        public string  NomPropriete { get; set; }

        public string  Cle { get; set; }

        public string  ValeurInitiale { get; set; }

        public string  ValeurCourante { get; set; }

        public string  NomUtilisateur { get; set; }

        public DateTime? DateChangement { get; set; }
    }
}