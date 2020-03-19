using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Services
{
    using Models;
    public interface UtilisateurService
    {
        public IEnumerable<Utilisateur> TrouverTous();
        public IEnumerable<Utilisateur> TrouverParId(int id);
        public IEnumerable<Utilisateur> TrouverParNom(string nom);
        public IEnumerable<Utilisateur> TrouverParPrenom(string prenom);
        public IEnumerable<Utilisateur> TrouverParAge(int age);
        public Utilisateur Modifier(Utilisateur user);
        public Utilisateur Save(Utilisateur user);
        public void Supprimer(int id);
    }
}
