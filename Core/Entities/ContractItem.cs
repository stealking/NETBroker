using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class ContractItem : BaseCreateTable
    {
        private ContractItem()
        {
            
        }

        public ContractItem(int id, int contractId, string? utilityAccountNumber, DateTime startDate, DateTime? endDate, int termMonth, string? productType, string? energyUnitType, int? annualUsage, decimal? rate, decimal? adder, int creator)
        {
            Id = id;
            ContractId = contractId;
            UtilityAccountNumber = utilityAccountNumber;
            StartDate = startDate;
            EndDate = endDate;
            TermMonth = termMonth;
            ProductType = productType;
            EnergyUnitType = energyUnitType;
            AnnualUsage = annualUsage;
            Rate = rate;
            Adder = adder;
            Creator = creator;
        }

        public ContractItem(int id, int contractId, string? utilityAccountNumber, DateTime startDate, DateTime? endDate, int termMonth, string? productType, string? energyUnitType, int? annualUsage, decimal? rate, decimal? adder, int creator, DateTime dateCreated, bool isActive)
        {
            Id = id;
            ContractId = contractId;
            UtilityAccountNumber = utilityAccountNumber;
            StartDate = startDate;
            EndDate = endDate;
            TermMonth = termMonth;
            ProductType = productType;
            EnergyUnitType = energyUnitType;
            AnnualUsage = annualUsage;
            Rate = rate;
            Adder = adder;
            Creator = creator;
            DateCreated = dateCreated;
            IsActive = isActive;
        }

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required field.")]
        public int ContractId { get; set; }

        [Required(ErrorMessage = "UtilityAccountNumber is required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the UtilityAccountNumber is {1} characters.")]
        public string? UtilityAccountNumber { get; set; }

        [Required(ErrorMessage = "Start Date is required field.")]
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "TermMonth is required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "The minimum value of TermMonth is 1")]
        public int TermMonth { get; set; }
        public string? ProductType { get; set; }
        public string? EnergyUnitType { get; set; }
        public int? AnnualUsage { get; set; }

        [DisplayFormat(DataFormatString = "{0:N5}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{1,5}(\.\d{1,5})?$", ErrorMessage = "Invalid Rate format.")]
        public decimal? Rate { get; set; }

        [DisplayFormat(DataFormatString = "{0:N5}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{1,5}(\.\d{1,5})?$", ErrorMessage = "Invalid Adder format.")]
        public decimal? Adder { get; set; }

        public Contract? Contract { get; set; }
    }
}
