using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieReferenceForInternship.Models
{
    public class Movies
    {
        public long Id { get; set; }
        public GenreReference GenreReference { get; set; }
        public int GenreReferenceId { get; set; }
        public string Name { get; set; }
        public DateTime RentalStartDate { get; set; }
        public DateTime RentelEndDate { get; set; }
        public bool Relevance { get; set; }

    }
}
