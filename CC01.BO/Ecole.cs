using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC01.BO
{
    [Serializable]
    public class Ecole
    {

        public string Nom { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public DateTime Creation { get; set; }

        public byte[] Logo;

        public Ecole(string nom, string email, string contact, DateTime creation, byte[] logo)
        {
            Nom = nom;
            Email = email;
            Contact = contact;
            Creation = creation;
            Logo = logo;
        }

        public override bool Equals(object obj)
        {
            return obj is Ecole ecole &&
                   Nom == ecole.Nom;
        }

        public override int GetHashCode()
        {
            return 574969646 + EqualityComparer<string>.Default.GetHashCode(Nom);
        }
    }
}
