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
    public class MovieController : ControllerBase
    {
        private readonly MovieApplication _movieApplication;
        public MovieController(MovieApplication movieApplication)
        {
            _movieApplication = movieApplication;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_movieApplication.GetAll());
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
                return Ok(_movieApplication.GetMovie(id));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Movie movie)
        {
            try
            {
                _movieApplication.InsertMovie(movie);

                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Put([FromBody] Movie movie, int id)
        {
            try
            {
                _movieApplication.UpdateMovie(movie, id);

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
                _movieApplication.DeleteMovie(id);

                return Ok();
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}

