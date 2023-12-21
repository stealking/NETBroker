using Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public abstract class CommisionType
    {
        public CommisionType(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent)
        {
            SalesProgramId = salesProgramId;
            CommissionConfigurationType = commissionConfigurationType;
            ProgramAdderType = programAdderType;
            ProgramAdder = programAdder;
            MarginPercent = marginPercent;
        }

        [Key]
        public int Id { get; init; }
        [Required]
        public string? CommissionConfigurationType { get; private set; }

        public DateConfig? DateConfig { get; private set; }

        public ProgramAdderType ProgramAdderType { get; private set; }
        public decimal ProgramAdder { get; private set; }
        public decimal MarginPercent { get; private set; }

        [Required]
        public int? SalesProgramId { get; private set; }
        public SaleProgram? SaleProgram { get; private set; }

        public virtual List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            return new List<ContractItemForecast>();
        }

        public void SetDateConfig(DateConfig dateConfig)
        {
            DateConfig = dateConfig;
        }
    }

    public class ContractUpfront : CommisionType
    {
        public ContractUpfront(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
        }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var contractMargin = Math.Round(contractItem.AnnualUsage * contractItem.Adder / 12 * contractItem.TermMonth, 2);
            var percentageOfContractMargin = Math.Round(contractMargin * MarginPercent, 2, MidpointRounding.AwayFromZero);
            return new List<ContractItemForecast>()
            {
                new ContractItemForecast(contractItem.Id, percentageOfContractMargin, DateConfig.GetForecastDate(contractItem))
            };
        }
    }

    public class PercentageContractResidual : CommisionType
    {
        public PercentageContractResidual(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
        }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var contractMargin = Math.Round(contractItem.AnnualUsage * contractItem.Adder / 12 * contractItem.TermMonth, 2);
            var percentageOfContractMargin = Math.Round(contractMargin * MarginPercent, 2);
            var residualQuantity = contractItem.TermMonth - contractItem.ContractItemForecasts.Count;
            var residualAmount = Math.Round(contractMargin / contractItem.TermMonth, MidpointRounding.AwayFromZero);
            var contractItemForecasts = new List<ContractItemForecast>();
            for (int i = 0; i < residualQuantity; i++)
            {
                var forecastDate = i > 0 ? contractItemForecasts.Last().ForecastDate.AddMonths(1) : contractItem.ContractItemForecasts.LastOrDefault()?.ForecastDate.AddMonths(1) ?? contractItem.Contract.SoldDate;
                var amount = i >= residualQuantity - 1 ? percentageOfContractMargin - contractItemForecasts.Sum(x => x.Amount) : residualAmount;
                contractItemForecasts.Add(new ContractItemForecast(contractItem.Id, amount, forecastDate));
            }
            return contractItemForecasts;
        }
    }

    public class QuarterlyUpfront : CommisionType
    {
        public QuarterlyUpfront(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
        }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var contractMargin = Math.Round(contractItem.AnnualUsage * contractItem.Adder / 12 * contractItem.TermMonth, 2);
            var quarterMargin = Math.Round(contractItem.AnnualUsage * contractItem.Adder / 4, 2);
            var residualQuantity = contractItem.TermMonth / 3;
            var contractItemForecasts = new List<ContractItemForecast>();
            for (int i = 0; i < residualQuantity; i++)
            {
                var forecastDate = i == 0 ? DateConfig.GetForecastDate(contractItem) : contractItemForecasts.Last().ForecastDate.AddMonths(3);
                var amount = i >= residualQuantity - 1 ? contractMargin - contractItemForecasts.Sum(x => x.Amount) : quarterMargin;
                contractItemForecasts.Add(new ContractItemForecast(contractItem.Id, amount, forecastDate));
            }
            return contractItemForecasts;
        }
    }

    public class AnnualUpfront : CommisionType
    {
        public AnnualUpfront(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent, decimal discountPercentage) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
            DiscountPercentage = discountPercentage;
        }

        public decimal DiscountPercentage { get; private set; }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var amountPerYear = Math.Round(contractItem.AnnualUsage * ProgramAdder, MidpointRounding.AwayFromZero);
            if (contractItem.TermMonth < 12)
            {
                amountPerYear = Math.Round(contractItem.TermMonth * ProgramAdder / 12 * contractItem.AnnualUsage, 2, MidpointRounding.AwayFromZero);
            }
            var numberOfYears = contractItem.TermMonth / 12 + (contractItem.TermMonth % 12 != 0 ? 1 : 0);
            var firstDateForcast = DateConfig.GetForecastDate(contractItem);
            var contractMargin = Math.Round(contractItem.AnnualUsage * ProgramAdder / 12 * contractItem.TermMonth, 2, MidpointRounding.AwayFromZero);
            var contractItemForecasts = new List<ContractItemForecast>();
            for (int i = 1; i <= numberOfYears; i++)
            {
                var amount = i == numberOfYears ? contractMargin - contractItemForecasts.Sum(x => x.Amount) : amountPerYear;
                var forecast = new ContractItemForecast(contractItem.Id, amount, firstDateForcast.AddYears(i - 1));
                contractItemForecasts.Add(forecast);
            }
            if (DiscountPercentage > 0)
            {
                var discountForecast = new ContractItemForecast(contractItem.Id, Math.Round(-DiscountPercentage * amountPerYear / 100, 2, MidpointRounding.AwayFromZero), firstDateForcast);
                contractItemForecasts.Add(discountForecast);
            }

            return contractItemForecasts;
        }
    }

    public class Bridge : CommisionType
    {
        public Bridge(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent, decimal fee) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
            Fee = fee;
        }

        public decimal Fee { get; private set; }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var dateForcast = DateConfig.GetForecastDate(contractItem);
            return new List<ContractItemForecast> { new ContractItemForecast(contractItem.Id, Fee, dateForcast) };
        }
    }

    public class FirstAnnualUpfront : CommisionType
    {
        public FirstAnnualUpfront(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent, decimal discountPercentage) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
            DiscountPercentage = discountPercentage;
        }

        public decimal DiscountPercentage { get; private set; }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var amountPerYear = Math.Round(contractItem.TermMonth < 12 ? (contractItem.TermMonth * ProgramAdder / 12 * contractItem.AnnualUsage) : contractItem.AnnualUsage * ProgramAdder, 2, MidpointRounding.AwayFromZero);
            var dateForcast = DateConfig.GetForecastDate(contractItem);
            var contractItemForecasts = new List<ContractItemForecast>
            {
                new ContractItemForecast(contractItem.Id, amountPerYear, dateForcast)
            };
            if (DiscountPercentage > 0)
            {
                contractItemForecasts.Add(new ContractItemForecast(contractItem.Id, Math.Round(-amountPerYear * DiscountPercentage / 100, 2, MidpointRounding.AwayFromZero), dateForcast));
            }
            return contractItemForecasts;
        }
    }

    public class FirstAnnualUpfront25kMax : CommisionType
    {
        public FirstAnnualUpfront25kMax(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
        }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var amountPerYear = Math.Round(contractItem.TermMonth < 12 ? contractItem.TermMonth * ProgramAdder / 12 * contractItem.AnnualUsage : contractItem.AnnualUsage * ProgramAdder, 2, MidpointRounding.AwayFromZero);
            if (amountPerYear > 25000)
            {
                amountPerYear = 25000;
            }
            var dateForcast = DateConfig.GetForecastDate(contractItem);
            return new List<ContractItemForecast> { new ContractItemForecast(contractItem.Id, amountPerYear, dateForcast) };
        }
    }

    public class PercentageAdderResidual : CommisionType
    {
        public PercentageAdderResidual(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
        }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var contractMargin = Math.Round(contractItem.AnnualUsage * ProgramAdder / 12 * MarginPercent *  contractItem.TermMonth, 2, MidpointRounding.AwayFromZero);
            var amountPerMonth = Math.Round(contractMargin / contractItem.TermMonth, 2, MidpointRounding.AwayFromZero);
            var firstForecastDate = DateConfig.GetForecastDate(contractItem);
            var contractItemForecasts = new List<ContractItemForecast>();
            for (int i = 1; i <= contractItem.TermMonth; i++)
            {
                var amount = i == contractItem.TermMonth ? contractMargin - contractItemForecasts.Sum(x => x.Amount) : amountPerMonth;
                contractItemForecasts.Add(new ContractItemForecast(contractItem.Id, amount, firstForecastDate.AddMonths(i-1)));
            }

            return contractItemForecasts;
        }
    }

    public class PercentageFirstAnnualRemainderResidual : CommisionType
    {
        public PercentageFirstAnnualRemainderResidual(int? salesProgramId, string commissionConfigurationType, ProgramAdderType programAdderType, decimal programAdder, decimal marginPercent) : base(salesProgramId, commissionConfigurationType, programAdderType, programAdder, marginPercent)
        {
        }

        public override List<ContractItemForecast> GetContractItemForecast(ContractItem contractItem)
        {
            var contractMargin = Math.Round(contractItem.AnnualUsage * ProgramAdder / 12 * MarginPercent * contractItem.TermMonth, 2, MidpointRounding.AwayFromZero);
            var amountPerMonth = Math.Round(contractMargin / contractItem.TermMonth, 2, MidpointRounding.AwayFromZero);
            var firstForecastDate = DateConfig.GetForecastDate(contractItem);
            var contractItemForecasts = new List<ContractItemForecast>();
            var totalMonth = contractItem.TermMonth <= 12 ? contractItem.TermMonth : 12;
            for (int i = 1; i <= totalMonth; i++)
            {
                var amount = i == contractItem.TermMonth ? contractMargin - contractItemForecasts.Sum(x => x.Amount) : amountPerMonth;
                contractItemForecasts.Add(new ContractItemForecast(contractItem.Id, amountPerMonth, firstForecastDate));
                firstForecastDate = firstForecastDate.AddMonths(1);
            }

            return contractItemForecasts;
        }
    }
}
