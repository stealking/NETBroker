﻿using Core.Entities.Enums;
using Core.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class ContractItem : BaseCreateTable
    {
        private ContractItem()
        {

        }

        public ContractItem(int id, int contractId, string? utilityAccountNumber, DateTime startDate, int termMonth, ProductTypes productType, EnergyUnitTypes energyUnitType, int? annualUsage, decimal? rate, decimal? adder, int creator, Status status)
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
            Status = status;

            var productTypeOfEnergy = energyUnitType.GetProductType();
            if (productType != productTypeOfEnergy)
            {
                throw new ArgumentException($"{energyUnitType} does not belong product type: {productType}");
            }
        }

        public ContractItem(int id, int contractId, string? utilityAccountNumber, DateTime startDate, int termMonth, ProductTypes productType, EnergyUnitTypes energyUnitType, int? annualUsage, decimal? rate, decimal? adder, int creator, Status status, Contract contract)
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
            Status = status;
            Contract = contract;

            var productTypeOfEnergy = energyUnitType.GetProductType();
            if (productType != productTypeOfEnergy)
            {
                throw new ArgumentException($"{energyUnitType} does not belong product type: {productType}");
            }
        }

        [Key]
        public int Id { get; init; }

        [Required(ErrorMessage = "ContractId is required field.")]
        public int ContractId { get; private set; }
        public Contract? Contract { get; private set; }

        [Required(ErrorMessage = "UtilityAccountNumber is required field.")]
        [MaxLength(20, ErrorMessage = "Maximum length for the UtilityAccountNumber is {1} characters.")]
        public string? UtilityAccountNumber { get; private set; }

        [Required(ErrorMessage = "Start Date is required field.")]
        public DateTime StartDate { get; private set; }

        public DateTime? EndDate => StartDate.AddMonths(TermMonth);

        [Required(ErrorMessage = "TermMonth is required field.")]
        [Range(0, int.MaxValue, ErrorMessage = "The minimum value of TermMonth is 0")]
        public int TermMonth { get; private set; }

        public ProductTypes ProductType { get; private set; }

        public EnergyUnitTypes EnergyUnitType { get; private set; }

        public int? AnnualUsage { get; private set; }

        [DisplayFormat(DataFormatString = "{0:N5}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{1,5}(\.\d{1,5})?$", ErrorMessage = "Invalid Rate format.")]
        public decimal? Rate { get; private set; }

        [DisplayFormat(DataFormatString = "{0:N5}", ApplyFormatInEditMode = true)]
        [RegularExpression(@"^\d{1,5}(\.\d{1,5})?$", ErrorMessage = "Invalid Adder format.")]
        public decimal? Adder { get; private set; }

        public Status Status { get; set; } = Status.None;
        public ForecastStateEnums? ForecastStateEnum { get; private set; }

        public int? SaleProgramId { get; private set; }
        public SaleProgram? SaleProgram { get; private set; }

        public ICollection<ContractItemAttachment> Attachments { get; private set; } = new List<ContractItemAttachment>();

        public ICollection<ContractItemForecast> ContractItemForecasts { get; private set; } = new List<ContractItemForecast>();


        public (bool, ContractItem) VerifyForecastability(List<SaleProgram> salePrograms)
        {
            if (Status == Status.None)
            {
                ForecastStateEnum = ForecastStateEnums.InvalidSalesData;
                return (false, this);
            }

            if (Status == Status.Rejected)
            {
                ForecastStateEnum = ForecastStateEnums.RejectedDeal;
                return (false, this);
            }

            if (Contract != null)
            {
                ForecastStateEnum = ForecastStateEnums.InvalidSalesData;
                return (false, this);
            }

            if (Contract?.Supplier == null)
            {
                ForecastStateEnum = ForecastStateEnums.MissingSalesProgram;
                return (false, this);
            }

            var validSalePrograms = salePrograms.Where(x => x.Qualifications.Any(x => x.IsValidQualification(this)));
            if (validSalePrograms.Any())
            {
                ForecastStateEnum = ForecastStateEnums.MissingSalesProgram;
                return (false, this);
            }
            else
            {
                var saleProgram = validSalePrograms
                    .OrderByDescending(x => x.Qualifications.Count())
                    .ThenByDescending(x => x.Qualifications.OfType<ExpirationQualification>().Max(m => m.EffectiveDate))?.FirstOrDefault();

                if (saleProgram?.CommisionTypes?.Any(x => x.ProgramAdder == null || x.DateConfig == null) ?? false)
                {
                    ForecastStateEnum = ForecastStateEnums.InvalidSalesData;
                    return (false, this);
                }

                SaleProgramId = saleProgram?.Id;
            }

            ForecastStateEnum = ForecastStateEnums.Reforecast;
            return (true, this);
        }
    }
}
