using System.ComponentModel.DataAnnotations;

namespace NetPay.Data.Models
{
    public class Service
    {
        public Service()
        {
            Expenses = new HashSet<Expense>();
            SuppliersServices = new HashSet<SupplierService>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5)]
        public string ServiceName { get; set; } = null!;

        public virtual ICollection<Expense> Expenses { get; set; }

        public virtual ICollection<SupplierService> SuppliersServices { get; set; }
    }
}