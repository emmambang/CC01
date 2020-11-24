using System;

namespace CC01.BO
{
    public class Class1
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Identifiant { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime Birthday { get; set; }

        public Class1(string nom, string prenom, string identifiant, string email, string contact, DateTime birthday)
        {
            Nom = nom;
            Prenom = prenom;
            Identifiant = identifiant;
            Email = email;
            Contact = contact;
            Birthday = birthday;
        }
    }
}
