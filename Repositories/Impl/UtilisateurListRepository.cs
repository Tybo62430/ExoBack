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

        public Utilisateur FindByAge(int age)
        {
            return this.Utilisateurs[age];
        }

        public Utilisateur FindById(int id)
        {
            return this.Utilisateurs[id];
        }

        public Utilisateur FindByNom(int nom)
        {
            return this.Utilisateurs[nom];
        }

        public Utilisateur FindByPrenom(int prenom)
        {
            return this.Utilisateurs[prenom];
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
