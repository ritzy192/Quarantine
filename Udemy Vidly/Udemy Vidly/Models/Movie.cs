using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Udemy_Vidly.Models;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenreTypes GenreType { get; set; }
        public int GenreTypeId { get; set; }
        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int InStockCount { get; set; }
    }
}