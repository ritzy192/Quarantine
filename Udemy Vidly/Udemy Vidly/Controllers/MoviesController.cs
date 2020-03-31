using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Udemy_Vidly.Models;
using System.Data.Entity;
using Vidly.Models;
using Vidly.ViewModel;
using Udemy_Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        public ActionResult Index()
        {
            if(User.IsInRole(RoleName.CanChangeMovies))
                return View("List");
            else
                return View("ReadOnlyList");
        }
        [Authorize(Roles = RoleName.CanChangeMovies)]
        public ActionResult Details(int Id)
        {
            var movie = _context.Movies.Include(m => m.GenreType).SingleOrDefault(m => m.Id == Id);
            return View(movie);
        }
        [Authorize(Roles = RoleName.CanChangeMovies)]
        public ActionResult New()
        {
            var genreTypes = _context.GenreTypes.ToList();
            var viewModel = new MovieFormViewModel()
            {
                GenreTypes = genreTypes
            };
            return View("MovieForm",viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = RoleName.CanChangeMovies)]
        public ActionResult Save(Movie movie)
        {
            //if (!ModelState.IsValid)
            //{
            //    var viewModel = new MovieFormViewModel(movie)
            //    {
            //        GenreTypes = _context.GenreTypes.ToList()
            //    };
            //    return View("MovieForm", viewModel);
            //}
            if (movie.Id == 0)
            {
                movie.DateAdded = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.GenreType = movie.GenreType;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.DateAdded = movie.DateAdded;
                movieInDb.InStockCount = movie.InStockCount;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        [Authorize(Roles = RoleName.CanChangeMovies)]
        public ActionResult Edit(int Id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == Id);
            if (movie == null)
                return HttpNotFound();
            var viewModel = new MovieFormViewModel(movie)
            {
                GenreTypes = _context.GenreTypes.ToList()

            };
            return View("MovieForm", viewModel);
        }

        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Intersteller" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Aditi" },
                new Customer { Name = "Aadi" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
    }
}