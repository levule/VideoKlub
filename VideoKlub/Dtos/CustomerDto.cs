using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using VideoKlub.Models;

namespace VideoKlub.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Obavezno je uneti ime.")]
        [StringLength(50)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }


        [Required(ErrorMessage = "Obavezno je odabrati clanstvo.")]
        public byte MembershipTypeId { get; set; }

        public MembershipTypeDto MembershipType { get; set; }

        //[Min18YearOldCustomer]
        public DateTime? Birthdate { get; set; }
    }
}