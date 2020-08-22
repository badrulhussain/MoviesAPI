using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MoviesAPI.Entites;
using MoviesAPI.Service;

namespace MoviesAPI.Controllers
{
    //[Route("api/[Controller]")]
    [Route("api/genres")]
    [ApiController]
    public class GenresController : ControllerBase
    {
        private readonly IRepository repositoy;
        public GenresController(IRepository repositoy)
        {
            this.repositoy = repositoy;
        }

        [HttpGet] // api/genres
        [HttpGet("List")] // api/genres/List
        [HttpGet("/allgenres")] // /Allgenres
        public async Task<ActionResult<List<Genre>>> Get()
        {
            return await repositoy.GetAllGenres();
        }

        //[HttpGet("example")] // api/genres/examlpe
        //[HttpGet("{Id}")] // api/genres/1
        //[HttpGet("{Id}/{param=badrul}")] // api/genres/1/otherName
        [HttpGet("{Id:int}")] // api/genres/2
        //public ActionResult<Genre> Get(int Id, [BindRequired] string param2)
        //public ActionResult<Genre> Get(int Id, [FromHeader] string param2)
        public ActionResult<Genre> Get(int Id, [FromServices] string param2)
        {
            var genre = repositoy.GetGenreById(Id);
            if (genre == null)
            {
                return NotFound();
            }

            return genre;
        }

        [HttpPost]
        public ActionResult Post([FromBody] Genre Genre)
        {
            return NoContent();
        }

        [HttpPut]
        public ActionResult Put([FromBody] Genre Genre)
        {
            return NoContent();
        }

        [HttpDelete]
        public ActionResult Delete()
        {
            return NoContent();
        }
    }
}