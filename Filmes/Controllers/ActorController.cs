using Microsoft.AspNetCore.Mvc;
using Filmes.Aplication;
using Filmes.Models;
using Microsoft.AspNetCore.Cors;
using System;
using System.Linq;

namespace Filmes_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("DistritoFilmesPolicy")]
    public class ActorController : ControllerBase
    {
        private readonly ActorApplication _actorApplication;
        public ActorController(ActorApplication actorApplication)
        {
            _actorApplication = actorApplication;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_actorApplication.GetAll());
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpGet("Find")]
        public IActionResult Find(int id)
        {
            try
            {
                return Ok(_actorApplication.GetActor(id));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Actor actor)
        {
            try
            {
                _actorApplication.InsertActor(actor);

                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Actor actor, int id)
        {
            try
            {
                _actorApplication.UpdateActor(actor, id);

                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _actorApplication.DeleteActor(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
