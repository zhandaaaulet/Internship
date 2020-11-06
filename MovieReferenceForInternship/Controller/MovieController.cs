using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieReferenceForInternship.Models;
using MovieReferenceForInternship.Repositories.Interfaces;

namespace MovieReferenceForInternship.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private readonly IMovieRepository _movieRepository;

        public MovieController(IMovieRepository movieRepository) => _movieRepository = movieRepository;

        [HttpGet("relevance/{id}")]
        public async Task<IActionResult> GetByRelevance(int id) => Ok(await _movieRepository.GetByRelevance(id));

        [HttpGet("range/{dateTime}")]
        public IActionResult GetByDateRange(DateTime dateTime) => Ok(_movieRepository.GetByDateRange(dateTime));

        [HttpGet("genre/{id}")]
        public IActionResult GetByGenre(int id) => Ok(_movieRepository.GetByGenre(id));

        [HttpGet("name/{name}")]
        public IActionResult GetByMovieName(string name) => Ok(_movieRepository.GetByMovieName(name));




    }
}
