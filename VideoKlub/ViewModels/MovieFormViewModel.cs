using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoKlub.Models;

namespace VideoKlub.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti ime.")]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Zanr")]
        [Required(ErrorMessage = "Obavezno je odabrati zanr.")]
        public byte? GenreId { get; set; }

        [Display(Name = "Datum objavljivanja")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name = "Na stanju")]
        [Range(1, 20, ErrorMessage = "Broj mora biti u opsegu 1-20")]
        public byte? NumberInStock { get; set; }

        public String Title
        {
            get
            {
                return Id != 0 ? "Izmeni film" : "Dodaj film";
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
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}