using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movies_Blazor.Shared.Models;

namespace Movies_Blazor.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie
                {
                    Title = "Spider Man: Far From Home",
                    ReleaseDate = new DateTime(2019, 7, 2)
                },
                new Movie
                {
                    Title = "Moana",
                    ReleaseDate = new DateTime(2015, 7, 2)
                },
                new Movie
                {
                    Title = "Zootopia",
                    ReleaseDate = new DateTime(2018, 7, 2)
                }
            };
        }
    }
}
