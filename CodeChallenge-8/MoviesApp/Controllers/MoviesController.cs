using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MoviesApp.Models;
using MoviesApp.Repository;


namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        IMovieRepository repo = new MovieRepository();
        public ActionResult Index()
        {
            return View(repo.GetAll());
        }
         public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            repo.Add(movie);
            repo.Save();
            return RedirectToAction("Index");
        }
         public ActionResult Edit(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            repo.Update(movie);
            repo.Save();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            return View(repo.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            repo.Delete(id);
            repo.Save();
            return RedirectToAction("Index");
        }

        public ActionResult MoviesByYear(int year)
        {
            return View(repo.GetMoviesByYear(year));
        }

        public ActionResult MoviesByDirector(string director)
        {
            return View(repo.GetMoviesByDirector(director));
        }
    }
}
