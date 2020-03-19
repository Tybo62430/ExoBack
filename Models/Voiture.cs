using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Models
{
    public class Voiture
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public string Imatriculation { get; set; }
        public Utilisateur Proprietaire { get; set; }
    }
}
