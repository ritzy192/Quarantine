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
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public GenreTypes GenreType { get; set; }
        [Display(Name = "Genre")]
        [Required]
        public int GenreTypeId { get; set; }
        [Required]
        [Display(Name = "Date Of Release")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Available Since")]
        public DateTime DateAdded { get; set; }
        [Required]
        [Range(1,20)]
        public int InStockCount { get; set; }
    }
}