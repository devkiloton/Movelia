using Movelia.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movelia.Client.Helpers
{
    public interface IRepository
    {
        List<Movie> GetMovies();
    }
}