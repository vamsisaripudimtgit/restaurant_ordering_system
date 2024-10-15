using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingSystem.Models
{
    public class Menu
    {
        [Key]
        [StringLength(15)]
        public string? Item_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string? Item_Name { get; set; }

        public string? Description { get; set; }

        [Required]
        public decimal? Price { get; set; }

        public bool? Availability { get; set; }

        public ICollection<Order>? Orders { get; set; }
    }
}
