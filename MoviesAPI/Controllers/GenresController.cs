using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Entites;
using MoviesAPI.Service;

namespace MoviesAPI.Controllers
{
    //[Route("api/[Controller]")]
    [Route("api/genres")]
    public class GenresController : ControllerBase
    {
        private readonly IRepository repositoy;
        public GenresController(IRepository repositoy)
        {
            this.repositoy = repositoy;
        }

        [HttpGet] // api/genres
        [HttpGet("List")]
        [HttpGet("/allgenres")] // /Allgenres
        public List<Genre> Get()
        {
            return repositoy.GetAllGenres();
        }

        //[HttpGet("example")] // api/genres/examlpe
        //[HttpGet("{Id}")] // api/genres/1
        //[HttpGet("{Id}/{param=badrul}")] // api/genres/1/otherName
        [HttpGet("{Id:int}/{param=badrul}")] // api/genres/otherName
        public Genre Get(int Id, string param)
        {
            var genre = repositoy.GetGenreById(Id);
            if (genre == null)
            {
                //return NotFound();
            }

            return genre;
        }

        [HttpPost]
        public void Post()
        {
            
        }

        [HttpPut]
        public void Put()
        {
            
        }

        [HttpDelete]
        public void Delete()
        {
            
        }
    }
}