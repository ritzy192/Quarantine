using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Hum Sath Sath Hai" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Aaloo"},
                new Customer {Name = "Kaddu"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(String.Format("pageIndex = {0}&sotyBy = {1}", pageIndex, sortBy));
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(String.Format("year = {0} \n month{1}", year, month));   
        }
    }
}