using System.ComponentModel.DataAnnotations;

namespace NetPay.Data.Models
{
    public class Household
    {
        public Household()
        {
            Expenses = new HashSet<Expense>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string ContactPerson { get; set; } = null!;

        [StringLength(80, MinimumLength = 6)]
        public string Email { get; set; } = null!;

        [Required]
        [RegularExpression(@"^\+\d{3}/\d{3}-\d{6}$")]
        public string PhoneNumber { get; set; } = null!;

        public virtual ICollection<Expense> Expenses { get; set; }
    }
}
