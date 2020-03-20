using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExoBack.Services
{
    using Models;
    public interface VoitureService
    {
        public IEnumerable<Voiture> TrouverTous();
        public IEnumerable<Voiture> TrouverParId(int id);
        public IEnumerable<Voiture> TrouverParNom(string nom);
        public IEnumerable<Voiture> TrouverParMarque(string marque);
        public IEnumerable<Voiture> TrouverParImatriculation(string imatriculation);
        public Voiture Modifier(Voiture car);
        public Voiture Save(Voiture car);
        public void Supprimer(int id);
    }
}
