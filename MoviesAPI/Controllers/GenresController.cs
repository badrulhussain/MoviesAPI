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

        [HttpGet]
        public List<Genre> Get()
        {
            return repositoy.GetAllGenres();
        }

        //[HttpGet]
        //public Genre Get(int Id)
        //{
        //    var genre = repositoy.GetGenreById(Id);
        //    if(genre == null)
        //    {
        //        //return NotFound();
        //    }

        //    return genre;
        //}

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