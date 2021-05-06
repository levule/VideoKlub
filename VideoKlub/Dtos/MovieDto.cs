using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoKlub.Models;

namespace VideoKlub.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti ime.")]
        [StringLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Obavezno je odabrati zanr.")]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 20, ErrorMessage = "Broj mora biti u opsegu 1-20")]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
    }
}