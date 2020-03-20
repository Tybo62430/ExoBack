using ExoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Services.Impl
{
    using Repositories;
    public class UtilisateurImplService : UtilisateurService
    {
        private UtilisateurRepository repository;

        public UtilisateurImplService(UtilisateurRepository repository)
        {
            this.repository = repository;
        }
        public Utilisateur Modifier(Utilisateur user)
        {
            return this.repository.Update(user);
        }

        public Utilisateur Save(Utilisateur user)
        {
            return this.repository.Save(user);
        }

        public void Supprimer(int id)
        {
            this.repository.Delete(id);
        }

        public IEnumerable<Utilisateur> TrouverParAge(int age)
        {
            return this.repository.FindByAge(age);
        }

        public Utilisateur TrouverParId(int id)
        {
            return this.repository.FindById(id);
        }

        public IEnumerable<Utilisateur> TrouverParNom(string nom)
        {
            return this.repository.FindByNom(nom);
        }

        public IEnumerable<Utilisateur> TrouverParPrenom(string prenom)
        {
            return this.repository.FindByPrenom(prenom);
        }

        public IEnumerable<Utilisateur> TrouverTous()
        {
            return this.repository.FindAll();
        }
    }
}
