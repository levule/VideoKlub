using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using VideoKlub.Models;

namespace VideoKlub.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Obavezno je uneti ime.")]
        [StringLength(50)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Odaberite clanstvo")]
        [Required(ErrorMessage = "Obavezno je odabrati clanstvo.")]
        public byte MembershipTypeId { get; set; }
        [Min18YearOldCustomer]
        public DateTime? Birthdate { get; set; }
    }
}