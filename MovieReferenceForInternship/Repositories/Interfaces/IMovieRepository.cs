using Microsoft.AspNetCore.Mvc;
using MovieReferenceForInternship.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReferenceForInternship.Repositories.Interfaces
{
    public interface IMovieRepository
    {
        Task<bool> GetByRelevance(int id);
        Movies GetByDateRange(DateTime dateTime);
        Movies GetByGenre(int id);
        Movies GetByMovieName(string name);
    }
}
