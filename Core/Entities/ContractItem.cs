using Core.Entities.Enums;
using Core.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ContractItem : BaseCreateTable
    {
        private ContractItem()
        {
            
        }

        public ContractItem(int id, int contractId, string? utilityAccountNumber, DateTime startDate, int termMonth, ProductTypes productType, EnergyUnitTypes energyUnitType, int? annualUsage, decimal? rate, decimal? adder, int creator)
        {
            Id = id;
            ContractId = contractId;
            UtilityAccountNumber = utilityAccountNumber;
            StartDate = startDate;
            TermMonth = termMonth;
            ProductType = productType;
            EnergyUnitType = energyUnitType;
            AnnualUsage = annualUsage;
            Rate = rate;
            Adder = adder;
            Creator = creator;

            var productTypeOfEnergy = energyUnitType.GetProductType();
            if (productType != productTypeOfEnergy)
            {
                throw new ArgumentException($"{energyUnitType} does not belong product type: {productType}");
            }
        }   

        [Key]
        public int Id { get; init; }

        [Required(ErrorMessage = "ContractId is required field.")]
        public int ContractId { get; set; }
        public Contract? Contract { get; set; }

        [Required(ErrorMessage = "UtilityAccountNumber is required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the UtilityAccountNumber is {1} characters.")]
        public string? UtilityAccountNumber { get; set; }

        [Required(ErrorMessage = "Start Date is required field.")]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate => StartDate.AddMonths(TermMonth);

        [Required(ErrorMessage = "TermMonth is required field.")]
        [Range(1, int.MaxValue, ErrorMessage = "The minimum value of TermMonth is 1")]
        public int TermMonth { get; set; }

        public ProductTypes ProductType { get; set; }

        public EnergyUnitTypes EnergyUnitType { get; set; }

        public int? AnnualUsage { get; set; }

        [DisplayFormat(DataFormatString = "{0:N5}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{1,5}(\.\d{1,5})?$", ErrorMessage = "Invalid Rate format.")]
        public decimal? Rate { get; set; }

        [DisplayFormat(DataFormatString = "{0:N5}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{1,5}(\.\d{1,5})?$", ErrorMessage = "Invalid Adder format.")]
        public decimal? Adder { get; set; }

        public ICollection<ContractItemAttachment> Attachments { get; set; } = new List<ContractItemAttachment>();
    }
}
