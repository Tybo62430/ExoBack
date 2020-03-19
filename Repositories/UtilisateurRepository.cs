using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Repositories
{
    using Models;
    public interface UtilisateurRepository
    {
        public Utilisateur Save(Utilisateur user);
        public IEnumerable<Utilisateur> FindAll();
        public IEnumerable<Utilisateur> FindById(int id);
        public IEnumerable<Utilisateur> FindByNom(string nom);
        public IEnumerable<Utilisateur> FindByPrenom(string prenom);
        public IEnumerable<Utilisateur> FindByAge(int age);
        public Utilisateur Update(Utilisateur user);
        public void Delete(int id);
        public void Delete(Utilisateur user);
    }
}
