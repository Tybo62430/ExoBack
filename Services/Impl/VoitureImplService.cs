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
        private UtilisateurService utilisateurService;

        public VoitureImplService(VoitureRepository repository, UtilisateurService utilisateurService)
        {
            this.repository = repository;
            this.utilisateurService = utilisateurService;
        }

        public Voiture Modifier(Voiture car)
        {
            return this.repository.Update(car);
        }

        public Voiture Save(Voiture car)
        {
            Utilisateur u = this.utilisateurService.TrouverParId(car.Proprietaire.Id);
            return u.Age >= 18 ? this.repository.Save(car) : null ; //controle age user, ajout si > 18
        }

        public void Supprimer(int id)
        {
            this.repository.Delete(id);
        }

        public Voiture TrouverParId(int id)
        {
            return this.repository.FindById(id);
        }

        public Voiture TrouverParImatriculation(string imatriculation)
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
