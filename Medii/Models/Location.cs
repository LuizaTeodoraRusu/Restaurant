using System.ComponentModel.DataAnnotations;

namespace Medii.Models
{
    public class Location
    {
        public int LocationId { get; set; }

        [Required]
        [Display(Name = "Nume")]

        public string Name { get; set; }

        [Display(Name = "Adresa")]

        [Required]
        public string Address { get; set; }

        //public ICollection<Reservation> Reservations { get; set; }
    }
}
