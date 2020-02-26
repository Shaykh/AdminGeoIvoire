namespace AdminGeoIvoire.Data
{
    public class Entite : IEntite
    {
        string  Createur { get; set; }

        DateTime? DateCreation { get; set; }

        string  DernierModificateur { get; set; }

        DateTime? DateDerniereModification { get; set; }

        bool Actif { get; set; }
    }
}