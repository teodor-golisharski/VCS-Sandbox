using NetPay.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace NetPay.Data.Models
{
    public class Expense
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string ExpenseName { get; set; } = null!;

        [Required]
        [Range(0.01, 100000)]
        public double Amount { get; set; }

        [Required]
        public DateTime DueDate { get; set; }

        [Required]
        public PaymentStatus PaymentStatus { get; set; }

        [Required]
        public int HouseholdId { get; set; }

        public virtual Household Household { get; set; } = null!;

        [Required]
        public int ServiceId { get; set; }

        public virtual Service Service { get; set; } = null!;
    }
}