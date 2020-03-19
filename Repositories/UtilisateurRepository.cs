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
        public Utilisateur FindById(int id);
        public Utilisateur FindByNom(int nom);
        public Utilisateur FindByPrenom(int prenom);
        public Utilisateur FindByAge(int age);
        public Utilisateur Update(Utilisateur user);
        public void Delete(int id);
        public void Delete(Utilisateur user);
    }
}
