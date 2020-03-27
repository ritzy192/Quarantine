using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Udemy_Vidly.Models;
using Vidly.Models;

namespace Udemy_Vidly.ViewModel
{
    public class MovieFormViewModel
    {
        public IEnumerable<GenreTypes> GenreTypes { get; set; }
        public int? Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public int? GenreTypeId { get; set; }
        [Required]
        [Display(Name = "Date Of Release")]
        public DateTime? ReleaseDate { get; set; }
        [Required]
        [Range(1, 20)]
        public int? InStockCount { get; set; }

        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            InStockCount = movie.InStockCount;
            GenreTypeId = movie.GenreTypeId;               
        }
    }
}