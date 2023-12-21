using Core.Entities;
using Core.Entities.Enums;

namespace TestProject
{
    public class ContractItemForecastTest
    {
        [Test]
        public void ContractUpfrontTest()
        {
            var commision = new ContractUpfront(1, "ContractUpfront", ProgramAdderType.Override, 0.007m, 0.5m);
            var dateConfig = new DateConfig(1, 1, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);

            var forecasts = commision.GetContractItemForecast(contractItem);
            var firstForecast = forecasts.FirstOrDefault();
            Assert.That(forecasts?.Count, Is.EqualTo(1));
            Assert.That(firstForecast?.Amount, Is.EqualTo(437.99m));
            Assert.That(firstForecast?.ForecastDate, Is.EqualTo(new DateTime(2023, 03, 31)));
        }

        [Test]
        public void PercentageContractResidualTest()
        {
            var commision = new PercentageContractResidual(1, "PercentageContractResidual", ProgramAdderType.Override, 0.007m, 0.5m);
            var dateConfig = new DateConfig(1, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);
            contractItem.ContractItemForecasts.Add(new ContractItemForecast(1, 100, new DateTime(2023, 01, 01)));
            contractItem.ContractItemForecasts.Add(new ContractItemForecast(1, 100, new DateTime(2023, 02, 01)));

            var forecasts = commision.GetContractItemForecast(contractItem);
            Assert.That(forecasts?.Count, Is.EqualTo(22));
            Assert.IsTrue(forecasts.Zip(forecasts.Skip(1), (a, b) => ((b.ForecastDate.Year - a.ForecastDate.Year) * 12 + b.ForecastDate.Month - a.ForecastDate.Month)).All(diff => diff == 1));
            Assert.That(forecasts.LastOrDefault()?.Amount, Is.EqualTo(-318.02));
        }

        [Test]
        public void QuarterlyUpfrontTest()
        {
            var commision = new QuarterlyUpfront(1, "QuarterlyUpfront", ProgramAdderType.Override, 0.007m, 0.5m);
            var dateConfig = new DateConfig(1, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);

            var forecasts = commision.GetContractItemForecast(contractItem);
            Assert.That(forecasts?.Count, Is.EqualTo(8));
            var firstForecast = forecasts.FirstOrDefault();
            Assert.That(firstForecast?.Amount, Is.EqualTo(109.50m));
            Assert.That(firstForecast.ForecastDate, Is.EqualTo(new DateTime(2023, 03, 31)));
            Assert.That(forecasts.LastOrDefault()?.Amount, Is.EqualTo(109.47));
            Assert.IsTrue(forecasts.Zip(forecasts.Skip(1), (a, b) => ((b.ForecastDate.Year - a.ForecastDate.Year) * 12 + b.ForecastDate.Month - a.ForecastDate.Month)).All(diff => diff == 3));
        }

        [Test]
        public void AnnualUpfrontTest()
        {
            var commision = new AnnualUpfront(1, "AnnualUpfront", ProgramAdderType.Override, 0.007m, 0.5m, 20);
            var dateConfig = new DateConfig(1, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);
            var forecasts = commision.GetContractItemForecast(contractItem);
            Assert.That(forecasts.Count, Is.EqualTo(3));
            Assert.That(forecasts.Where(x => x.Amount > 0).Count, Is.EqualTo(2));
            Assert.That(forecasts.Where(x => x.Amount < 0).FirstOrDefault()?.Amount, Is.EqualTo(-81.80));
        }

        [Test]
        public void BridgeTest()
        {
            var commision = new Bridge(1, "Bridge", ProgramAdderType.Override, 0.007m, 0.5m, 5000);
            var dateConfig = new DateConfig(1, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);
            var forecasts = commision.GetContractItemForecast(contractItem);
            Assert.That(forecasts.Count, Is.EqualTo(1));
            Assert.That(forecasts.FirstOrDefault()?.Amount, Is.EqualTo(5000));
        }

        [Test]
        public void FirstAnnualUpfrontTest()
        {
            var commision = new FirstAnnualUpfront(1, "FirstAnnualUpfront", ProgramAdderType.Override, 0.007m, 0.5m, 50);
            var dateConfig = new DateConfig(1, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);

            var forecasts = commision.GetContractItemForecast(contractItem);
            Assert.That(forecasts.Count, Is.EqualTo(2));
            Assert.That(forecasts.Where(x => x.Amount > 0).Count, Is.EqualTo(1));
            Assert.That(forecasts.Where(x => x.Amount < 0).Count, Is.EqualTo(1));
            Assert.That(forecasts.FirstOrDefault()?.Amount, Is.EqualTo(408.79));
            Assert.That(forecasts.Where(x => x.Amount < 0).FirstOrDefault()?.Amount, Is.EqualTo(-204.40));
        }


        [Test]
        public void FirstAnnualUpfront25MaxTest()
        {
            var commision = new FirstAnnualUpfront25kMax(1, "FirstAnnualUpfront", ProgramAdderType.Override, 0.007m, 0.5m);
            var dateConfig = new DateConfig(1, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);

            var forecasts = commision.GetContractItemForecast(contractItem);
            Assert.That(forecasts.Count, Is.EqualTo(1));
            Assert.That(forecasts.Where(x => x.Amount > 0).Count, Is.EqualTo(1));
            Assert.That(forecasts.Where(x => x.Amount < 0).Count, Is.EqualTo(0));
            Assert.That(forecasts.FirstOrDefault()?.Amount, Is.EqualTo(408.79));
        }

        [Test]
        public void PercentageAdderResidualTest()
        {
            var commision = new PercentageAdderResidual(1, "PercentageAdderResidual", ProgramAdderType.Override, 0.007m, 0.5m);
            var dateConfig = new DateConfig(1, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);

            var forecasts = commision.GetContractItemForecast(contractItem);
            Assert.That(forecasts.Count, Is.EqualTo(24));
            Assert.That(forecasts.Sum(x => x.Amount), Is.EqualTo(408.79));
            Assert.IsTrue(forecasts.Zip(forecasts.Skip(1), (a, b) => ((b.ForecastDate.Year - a.ForecastDate.Year) * 12 + b.ForecastDate.Month - a.ForecastDate.Month)).All(diff => diff == 1));
        }

        [Test]
        public void PercentageFirstAnnualRemainderResidualTest()
        {
            var commision = new PercentageFirstAnnualRemainderResidual(1, "PercentageFirstAnnualRemainderResidual", ProgramAdderType.Override, 0.007m, 0.5m);
            var dateConfig = new DateConfig(1, 2, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.DayOfWeek_Fridays, 2);
            commision.SetDateConfig(dateConfig);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None);
            contractItem.SetContract(contract);

            var forecasts = commision.GetContractItemForecast(contractItem);
            Assert.That(forecasts.Count, Is.EqualTo(12));
            Assert.That(forecasts.Sum(x => x.Amount), Is.EqualTo(204.36));
            Assert.IsTrue(forecasts.Zip(forecasts.Skip(1), (a, b) => ((b.ForecastDate.Year - a.ForecastDate.Year) * 12 + b.ForecastDate.Month - a.ForecastDate.Month)).All(diff => diff == 1));
        }
    }
}
