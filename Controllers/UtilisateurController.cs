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

    [Route("utilisateurs")]
    [ApiController]
    public class UtilisateurController : ControllerBase
    {
        private UtilisateurService service;

        public UtilisateurController(UtilisateurService service)
        {
            this.service = service;
        }

        [HttpPost]
        [Route("")]
        public Utilisateur Save([FromBody] Utilisateur user)
        {
            return this.service.Save(user);            
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Utilisateur> FindAll()
        {
            return this.service.TrouverTous();            
        }

        [HttpGet]
        [Route("{id}")]
        public IEnumerable<Utilisateur> FindById(int id)
        {
            return this.service.TrouverParId(id);
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IEnumerable<Utilisateur> FindByNom(string nom)
        {
            return this.service.TrouverParNom(nom);
        }

        [HttpGet]
        [Route("prenom/{prenom}")]
        public IEnumerable<Utilisateur> FindByPrenom(string prenom)
        {
            return this.service.TrouverParPrenom(prenom);
        }

        [HttpGet]
        [Route("age/{age}")]
        public IEnumerable<Utilisateur> FindByAge(int age)
        {
            return this.service.TrouverParAge(age);
        }

        [HttpPut]
        [Route("")]
        public Utilisateur Update([FromBody] Utilisateur user)
        {
            return this.service.Modifier(user);            
        }

        [HttpDelete]
        [Route("{id}")]
        public void Delete(int id)
        {
            this.service.Supprimer(id);            
        }
    }
}