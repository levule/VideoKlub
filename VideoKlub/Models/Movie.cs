using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VideoKlub.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obavezno je uneti ime.")]
        [StringLength(50)]
        public string Name { get; set; }
        public Genre Genre { get; set; }
        [Display(Name = "Zanr")]
        [Required(ErrorMessage = "Obavezno je odabrati zanr.")]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        [Display(Name = "Datum objavljivanja")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Na stanju")]
        [Range(1, 20, ErrorMessage = "Broj mora biti u opsegu 1-20")]
        public byte NumberInStock { get; set; }
        public byte NumberAvailable { get; set; }
    }
}