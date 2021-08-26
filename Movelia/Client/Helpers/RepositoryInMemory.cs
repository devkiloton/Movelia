using Movelia.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movelia.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){Title = "Spider Man: Far from home",ReleaseDate = new DateTime(2019, 7, 2)},
                new Movie(){Title = "Moana",ReleaseDate = new DateTime(2016, 11, 23)},
                new Movie(){Title = "Inception",ReleaseDate = new DateTime(2010, 7, 16)},
                new Movie(){Title = "We are legion",ReleaseDate = new DateTime(2012, 10, 12)},
            };
        }
    }
}