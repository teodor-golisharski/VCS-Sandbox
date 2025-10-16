namespace NetPay.Data.Models
{
    public class SupplierService
    {
        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; } = null!;

        public int ServiceId { get; set; }

        public Service Service { get; set; } = null!;
    }
}