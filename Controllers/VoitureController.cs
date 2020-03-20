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
        public IActionResult Save([FromBody] Voiture car)
        {
            return Ok(this.service.Save(car));
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
        [Route("marque/{marque}")]
        public IActionResult FindByPrenom(string marque)
        {            
            try
            {
                return Ok(this.service.TrouverParMarque(marque));
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
        [Route("imatriculation/{imatriculation}")]
        public IActionResult FindByImatriculation(string imatriculation)
        {            
            try
            {
                return Ok(this.service.TrouverParImatriculation(imatriculation));
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
        public IActionResult Update([FromBody] Voiture car)
        {
            return Ok(this.service.Modifier(car));
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