using Microsoft.EntityFrameworkCore;
using MovieReferenceForInternship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReferenceForInternship.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) 
        {

        }

        public DbSet<GenreReference> GenreReferences { get; private set; }
        public DbSet<Movies> Movies { get; private set; }
    }
}
