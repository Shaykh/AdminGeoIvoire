namespace AdminGeoIvoire.Data.Dbo
{
    public class UserInfo : IUserInfo
    {
        public UserInfo()
        { 
        }
        public UserInfo(string nomUtilisateur)
        {
            NomUtilisateur = nomUtilisateur;
        }
        public string NomUtilisateur { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

        public string Prenom { get; set; }

        public string Nom { get; set; }
    }
}