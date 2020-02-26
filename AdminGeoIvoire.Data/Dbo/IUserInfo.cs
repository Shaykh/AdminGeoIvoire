namespace AdminGeoIvoire.Data.Dbo
{
    public interface IUserInfo
    {
        string NomUtilisateur { get; set; }

        string Email { get; set; }

        string Role { get; set; }

        string Prenom { get; set; }

        string Nom { get; set; }
    }
}