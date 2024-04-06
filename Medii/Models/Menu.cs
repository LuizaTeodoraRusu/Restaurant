using System.ComponentModel.DataAnnotations;

namespace Medii.Models
{
    public class Menu
    {
        public int MenuId { get; set; }

        [Required]
        [Display(Name = "Tip meniu")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Pret")]
        public decimal Price { get; set; }

        [Display(Name = "Detalii")]
        public string? Details { get; set; }

        //public ICollection<Reservation> Reservations { get; set; }
    }
}
