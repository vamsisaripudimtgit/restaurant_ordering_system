using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RestaurantOrderingSystem.Models
{
    public class Payment
    {
        [Key]
        [StringLength(15)]
        public string? Payment_ID { get; set; }

        [Required]
        [StringLength(15)]
        public string? Customer_ID { get; set; }

        [ForeignKey("Customer_ID")]
        public Customer? Customer { get; set; }

        [Required]
        [StringLength(15)]
        public string? Order_ID { get; set; }

        [ForeignKey("Order_ID")]
        public Order? Order { get; set; }

        [Required]
        public decimal TotalAmount { get; set; }

        public bool PaymentStatus { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
