using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Services.Impl
{
    using ExoBack.Models;
    using Repositories ;
    public class VoitureImplService : VoitureService
    {
        private VoitureRepository repository;

        public VoitureImplService(VoitureRepository repository)
        {
            this.repository = repository;
        }

        public Voiture Modifier(Voiture car)
        {
            return this.repository.Update(car);
        }

        public Voiture Save(Voiture car)
        {
            return this.repository.Save(car);
        }

        public void Supprimer(int id)
        {
            this.repository.Delete(id);
        }

        public Voiture TrouverParId(int id)
        {
            return this.repository.FindById(id);
        }

        public IEnumerable<Voiture> TrouverParImatriculation(string imatriculation)
        {
            return this.repository.FindByImmatriculation(imatriculation);
        }

        public IEnumerable<Voiture> TrouverParMarque(string marque)
        {
            return this.repository.FindByMarque(marque);
        }

        public IEnumerable<Voiture> TrouverParNom(string nom)
        {
            return this.repository.FindByNom(nom);
        }

        public IEnumerable<Voiture> TrouverTous()
        {
            return this.repository.FindAll();
        }
    }
}
