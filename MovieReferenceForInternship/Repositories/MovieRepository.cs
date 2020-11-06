using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using MovieReferenceForInternship.Data;
using MovieReferenceForInternship.Models;
using MovieReferenceForInternship.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReferenceForInternship.Repositories
{
    public class MovieRepository : IMovieRepository
    {
        private readonly MovieContext _context;

        public MovieRepository(MovieContext context)
        {
            _context = context;
        }

        public Movies GetByDateRange(DateTime dateTime)
        {
            var movie = _context.Movies.FirstOrDefault(i => i.RentalStartDate <= dateTime && i.RentelEndDate <= dateTime);
            if (movie is null)
            {
                throw new ArgumentOutOfRangeException("In this range don't exist movie!");
            }
            return movie;



        }

        public Movies GetByGenre(int id) => _context.Movies.FirstOrDefault(i => i.GenreReferenceId == id);

        public Movies GetByMovieName(string name) => _context.Movies.FirstOrDefault(i => i.Name == name);

        public async Task<bool> GetByRelevance(int id)
        {
            var movie = await _context.Movies.FirstOrDefaultAsync(i => i.Id == id && i.Relevance == true);
            if (movie is { })
            {
                return true;
            }
            return false;
        }
    }
}
