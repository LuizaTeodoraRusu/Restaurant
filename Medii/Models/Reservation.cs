using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Medii.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }

        [Required]
        [Display(Name = "Locatia")]
        public int? LocationId { get; set; }

        [BindProperty]
        [Display(Name = "Locatia")]
        public Location? Location { get; set; }

        [Required]
        [Display(Name = "Meniu")]
        public int? MenuId { get; set; }

        [BindProperty]
        [Display(Name = "Meniu")]
        public Menu? Menu { get; set; }

        [Required]
        [Display(Name = "Data si ora")]
        public DateTime DateAndTime { get; set; }

        [Required]
        [Display(Name = "Telefon")]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Nume rezervare")]
        public string ReservationName { get; set; }
    }
}
