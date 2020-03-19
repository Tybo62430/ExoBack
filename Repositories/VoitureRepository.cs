using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Repositories
{
    using Models;
    interface VoitureRepository
    {
        public Voiture Save(Voiture car);
        public IEnumerable<Voiture> FindAll();
        public Voiture FindById(int id);
        public Voiture FindByNom(int nom);
        public Voiture FindByMarque(int marque);
        public Voiture FindByImmatriculation(int imatriculation);
        public Voiture Update(Voiture car);
        public void Delete(int id);
        public void Delete(Voiture car);
    }
}
