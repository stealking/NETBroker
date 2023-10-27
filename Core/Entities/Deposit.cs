using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Deposit
    {
        public Deposit()
        {
        }

        public Deposit(int id, int supplierId, DateTime paymentDate, decimal amount)
        {
            Id = id;
            SupplierId = supplierId;
            PaymentDate = paymentDate;
            Amount = amount;
        }

        [Key]
        public int Id { get; init; }

        [Required]
        public int SupplierId { get; set; }

        [Required]
        public DateTime PaymentDate  { get; set; }

        [Required]
        [RegularExpression(@"^\d{1,16}(\.\d{1,2})?$", ErrorMessage = "Invalid Amount format.")]
        public decimal Amount { get; set; }

        public Supplier? Supplier { get; set; }
    }
}
