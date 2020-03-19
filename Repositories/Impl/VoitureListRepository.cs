using ExoBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Repositories.Impl
{
    public class VoitureListRepository : VoitureRepository
    {
        private List<Voiture> voitures = new List<Voiture>();
        public void Delete(int id)
        {
            this.voitures[id] = null;
        }

        public void Delete(Voiture car)
        {
            this.voitures[car.Id] = null;
        }

        public IEnumerable<Voiture> FindAll()
        {
            return this.voitures.Where(v => v != null);
        }

        public IEnumerable<Voiture> FindById(int id)
        {
            return voitures.Where(v => v.Id == id);
        }

        public IEnumerable<Voiture> FindByImmatriculation(string imatriculation)
        {
            return voitures.Where(v => v.Imatriculation == imatriculation);
        }

        public IEnumerable<Voiture> FindByMarque(string marque)
        {
            return voitures.Where(v => v.Marque == marque);
        }

        public IEnumerable<Voiture> FindByNom(string nom)
        {
            return voitures.Where(v => v.Nom == nom);
        }

        public Voiture Save(Voiture car)
        {
            car.Id = this.voitures.Count();
            this.voitures.Add(car);
            return car;            
        }

        public Voiture Update(Voiture car)
        {            
            this.voitures[car.Id] = car;
            return car;
        }
    }
}
