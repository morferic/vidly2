using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer {Name = "John Smith"},
                new Customer {Name = "Barbra Dursey"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
            //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" }); // Fa una redirezione vertso index passandogli dei paramnetri
        }

        /* Di default il parametro passato si deve chiamare id. 
         * Basta vedere cosa c'e' come parametro di default in  routes.MapRoute nel file routeConfig.cs.
           Se cambiassimo nome al primo parametro e scrivessimo movies/edit/1 restituirebbe errore.*/
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        //
        public ViewResult Index()
        {
            var movies = getMovies();

            return View(movies);
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

        private IEnumerable<Movie> getMovies()
        {
            return new List<Movie>
            {
                new Movie {Id = 1, Name = "Shrek!"},
                new Movie {Id = 2, Name = "Wall-e"}
            };
        }

    }
}