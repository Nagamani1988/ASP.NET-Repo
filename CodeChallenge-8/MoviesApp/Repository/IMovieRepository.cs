using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesApp.Models;

namespace MoviesApp.Repository
{
    public interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        Movie GetById(int id);
        void Add(Movie movie);
        void Update(Movie movie);
        void Delete(int id);

        IEnumerable<Movie> GetMoviesByYear(int year);
        IEnumerable<Movie> GetMoviesByDirector(string director);
        void Save();
    }
}
