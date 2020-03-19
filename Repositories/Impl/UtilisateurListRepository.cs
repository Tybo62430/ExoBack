using ExoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Repositories.Impl
{
    public class UtilisateurListRepository : UtilisateurRepository
    {
        private List<Utilisateur> Utilisateurs = new List<Utilisateur>();
        public void Delete(int id)
        {
            this.Utilisateurs[id] = null;
        }

        public void Delete(Utilisateur user)
        {
            this.Utilisateurs[user.Id] = null;
        }

        public IEnumerable<Utilisateur> FindAll()
        {
            return this.Utilisateurs.Where(u => u != null);
        }

        public IEnumerable<Utilisateur> FindByAge(int age)
        {
            return Utilisateurs.Where(u => u.Age == age);
        }

        public IEnumerable<Utilisateur> FindById(int id)
        {
            return Utilisateurs.Where(u => u.Id == id);
        }

        public IEnumerable<Utilisateur> FindByNom(string nom)
        {
            return Utilisateurs.Where(u => u.Nom == nom);
        }

        public IEnumerable<Utilisateur> FindByPrenom(string prenom)
        {
            return Utilisateurs.Where(u => u.Prenom == prenom);
        }

        public Utilisateur Save(Utilisateur user)
        {
            user.Id = this.Utilisateurs.Count();
            this.Utilisateurs.Add(user);
            return user;
        }

        public Utilisateur Update(Utilisateur user)
        {            
            this.Utilisateurs[user.Id] = user;
            return user;
        }
    }
}
