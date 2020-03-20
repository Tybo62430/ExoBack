using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Repositories
{
    using Models;
    public interface VoitureRepository
    {
        public Voiture Save(Voiture car);
        public IEnumerable<Voiture> FindAll();
        public IEnumerable<Voiture> FindById(int id);
        public IEnumerable<Voiture> FindByNom(string nom);
        public IEnumerable<Voiture> FindByMarque(string marque);
        public IEnumerable<Voiture> FindByImmatriculation(string imatriculation);
        public Voiture Update(Voiture car);
        public void Delete(int id);
        public void Delete(Voiture car);
    }
}
