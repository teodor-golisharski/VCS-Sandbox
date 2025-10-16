using NetPay.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace NetPay.Data
{
    public class Supplier
    {
        public Supplier()
        {
            SuppliersServices = new HashSet<SupplierService>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string SupplierName { get; set; } = null!;

        public virtual ICollection<SupplierService> SuppliersServices { get; set; }
    }
}
