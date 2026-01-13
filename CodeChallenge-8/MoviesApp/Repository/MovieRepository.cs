using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MoviesApp.Models;

namespace MoviesApp.Repository
{
    public class MovieRepository : IMovieRepository
    {
        private MoviesContext db = new MoviesContext();

        public IEnumerable<Movie> GetAll()
        {
            return db.Movies.ToList();
        }

        public Movie GetById(int id)
        {
            return db.Movies.Find(id);
        }

        public void Add(Movie movie)
        {
            db.Movies.Add(movie);
        }

        public void Update(Movie movie)
        {
            db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(int id)
        {
            var movie = db.Movies.Find(id);
            if (movie != null)
                db.Movies.Remove(movie);
        }

        public IEnumerable<Movie> GetMoviesByYear(int year)
        {
            return db.Movies
                     .Where(m => m.DateOfRelease.Year == year)
                     .ToList();
        }

        public IEnumerable<Movie> GetMoviesByDirector(string director)
        {
            return db.Movies
                     .Where(m => m.DirectorName == director)
                     .ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}


