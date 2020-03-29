using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Udemy_Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int GenreTypeId { get; set; }
        [Required]
        public DateTime ReleaseDate { get; set; }
        public DateTime? DateAdded { get; set; }
        [Required]
        [Range(1, 20)]
        public int InStockCount { get; set; }
    }
}