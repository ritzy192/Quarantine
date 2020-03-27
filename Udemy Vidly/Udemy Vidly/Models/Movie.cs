using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Genre")]
        public int GenreTypeId { get; set; }
        [Display(Name = "Date Of Release")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Available Since")]
        public DateTime DateAdded { get; set; }
        public int InStockCount { get; set; }
    }
}