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
        public IActionResult Save([FromBody] Utilisateur user)
        {
            return Ok(this.service.Save(user));            
        }

        [HttpGet]
        [Route("")]
        public IActionResult FindAll()
        {
            return Ok(this.service.TrouverTous());            
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult FindById(int id)
        {
            try
            {
                return Ok(this.service.TrouverParId(id));
            }
            catch (IndexOutOfRangeException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return this.ValidationProblem(e.Message);
            }
        }

        [HttpGet]
        [Route("nom/{nom}")]
        public IActionResult FindByNom(string nom)
        {            
            try
            {
                return Ok(this.service.TrouverParNom(nom));
            }
            catch (IndexOutOfRangeException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return this.ValidationProblem(e.Message);
            }
        }

        [HttpGet]
        [Route("prenom/{prenom}")]
        public IActionResult FindByPrenom(string prenom)
        {            
            try
            {
                return Ok(this.service.TrouverParPrenom(prenom));
            }
            catch (IndexOutOfRangeException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return this.ValidationProblem(e.Message);
            }
        }

        [HttpGet]
        [Route("age/{age}")]
        public IActionResult FindByAge(int age)
        {            
            try
            {
                return Ok(this.service.TrouverParAge(age));
            }
            catch (IndexOutOfRangeException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return this.ValidationProblem(e.Message);
            }
        }

        [HttpPut]
        [Route("")]
        public IActionResult Update([FromBody] Utilisateur user)
        {
            return Ok(this.service.Modifier(user));            
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {            
            try
            {
                this.service.Supprimer(id);
                return Ok();
            }
            catch
            {
                return NotFound();
            }
        }
    }
}