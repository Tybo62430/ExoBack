using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExoBack.Controllers
{
    using Models;
    using Services;

    [Route("voitures")]
    [ApiController]
    public class VoitureController : ControllerBase
    {
        private VoitureService service;

        public VoitureController(VoitureService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("")]
        public Voiture Save([FromBody] Voiture car)
        {
            return this.service.Save(car);
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Voiture> FindAll()
        {
            return this.service.TrouverTous();
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Voiture> FindById(int id)
        {
            return this.service.TrouverParId(id);
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<Voiture> FindByNom(string nom)
        {
            return this.service.TrouverParNom(nom);
        }

        [HttpGet]
        [Route("marque/{marque}")]
        public IEnumerable<Voiture> FindByPrenom(string marque)
        {
            return this.service.TrouverParMarque(marque);
        }

        [HttpGet]
        [Route("imatriculation/{imatriculation}")]
        public IEnumerable<Voiture> FindByImatriculation(string imatriculation)
        {
            return this.service.TrouverParImatriculation(imatriculation);
        }

        [HttpPut]
        [Route("")]
        public Voiture Update([FromBody] Voiture car)
        {
            return this.service.Modifier(car);
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            this.service.Supprimer(id);
        }
    }
}