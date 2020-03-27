using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Udemy_Vidly.Models;
using Vidly.Models;

namespace Udemy_Vidly.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreTypes> GenreTypes { get; set; }
        public Movie Movie { get; set; }
    }
}