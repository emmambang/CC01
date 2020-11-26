using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
   public class Etudiant
    {
        public string Matricule { get; set; }

        public string Nom { get; set; }

        public string Prenom {get; set;}

        public DateTime DateNaissance { get; set; }

        public byte [] Photo { get; set; }

        public string Email { get; set; }

        public int Contact { get; set; }


        public Etudiant()
        {

        }
        public Etudiant(string matricule, string nom, string prenom, string lieuNaissance, 
            byte[] photo, string email, int contact, DateTime dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            Photo = photo;
            Email = email;
            Contact = contact;
            DateNaissance = dateNaissance;
        }

        public override bool Equals(object obj)
        {
            return obj is Etudiant etudiant &&
                   Matricule == etudiant.Matricule;
        }

        public override int GetHashCode()
        {
            return 797189699 + EqualityComparer<string>.Default.GetHashCode(Matricule);
        }
    }
}
