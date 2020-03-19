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

        public Voiture FindById(int id)
        {
            return this.voitures[id];
        }

        public Voiture FindByImmatriculation(int imatriculation)
        {
            return this.voitures[imatriculation];
        }

        public Voiture FindByMarque(int marque)
        {
            return this.voitures[marque];
        }

        public Voiture FindByNom(int nom)
        {
            return this.voitures[nom];
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
