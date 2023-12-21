using Core.Entities;
using Core.Entities.Enums;

namespace TestProject
{
    public class DateConfigTest
    {
        [Test]
        [TestCase(ControlDateTypes.SoldDate, ExpectedResult = "2023-03-14")]
        [TestCase(ControlDateTypes.ServiceStartDate, ExpectedResult = "2023-04-14")]
        [TestCase(ControlDateTypes.CustomerInvoiceDate, ExpectedResult = "2023-05-14")]
        [TestCase(ControlDateTypes.CustomerPaymentDate, ExpectedResult = "2023-06-14")]
        [TestCase(ControlDateTypes.SupplierInvoiceDate, ExpectedResult = "2023-04-18")]
        [TestCase(ControlDateTypes.UtilityAcceptanceDate, ExpectedResult = "2023-03-14")]
        public DateTime? ControlDateTest(ControlDateTypes controlDateTypes)
        {
            var dateConfig = new DateConfig(1, 1, controlDateTypes, ControlDateModifierTypes.NoModifier, ControlDateOffsetType.NoOffset, 0);
            var contract = new Contract(1, 1, "John A", 1, 1, 1, 1, new DateTime(2023, 03, 14), BillingChargeTypes.AllIn, BillingTypes.ChickenRanch, EnrollmentTypes.TPV, PricingTypes.Matrix, 1, Stage.Opportunity);
            var contractItem = new ContractItem(1, 1, "9138014006", new DateTime(2023, 04, 14), 24, ProductTypes.Elec, EnergyUnitTypes.KWH, 58398, (decimal)0.01275, (decimal)0.0075, 1, Status.None, contract);
            var result = dateConfig.GetControlDate(contractItem);
            return result;
        }

        [Test]
        [TestCase(ControlDateModifierTypes.NoModifier, "2023-12-11", ExpectedResult = "2023-12-11")]
        [TestCase(ControlDateModifierTypes.EndOfMonth, "2023-12-11", ExpectedResult = "2023-12-31")]
        [TestCase(ControlDateModifierTypes.EndOfQuarter, "2023-12-11", ExpectedResult = "2023-12-31")]
        [TestCase(ControlDateModifierTypes.OneMonthAfter, "2023-12-11", ExpectedResult = "2024-01-11")]
        [TestCase(ControlDateModifierTypes.TwoMonthsAfter, "2023-12-11", ExpectedResult = "2024-02-11")]
        [TestCase(ControlDateModifierTypes.ThreeMonthsAfter, "2023-12-11", ExpectedResult = "2024-03-11")]
        [TestCase(ControlDateModifierTypes.Days2ndOr16thOfMonthAfter, "2023-12-11", ExpectedResult = "2024-01-02")]
        [TestCase(ControlDateModifierTypes.Days2ndOr16thOfMonthAfter, "2023-12-20", ExpectedResult = "2024-01-16")]
        [TestCase(ControlDateModifierTypes.DaysAfter15thOfMonthAfter, "2023-12-11", ExpectedResult = "2024-01-15")]
        [TestCase(ControlDateModifierTypes.OneYearAfter, "2023-12-11", ExpectedResult = "2024-12-11")]
        [TestCase(ControlDateModifierTypes.Minus3Months, "2023-12-11", ExpectedResult = "2023-09-11")]
        [TestCase(ControlDateModifierTypes.Minus5Months, "2023-12-11", ExpectedResult = "2023-07-11")]
        [TestCase(ControlDateModifierTypes.FirstFridayAfter, "2023-12-11", ExpectedResult = "2023-12-15")]
        [TestCase(ControlDateModifierTypes.DayUpToOrAfter23rd, "2023-12-11", ExpectedResult = "2024-01-31")]
        [TestCase(ControlDateModifierTypes.DayUpToOrAfter23rd, "2023-12-25", ExpectedResult = "2024-02-29")]
        [TestCase(ControlDateModifierTypes.LastThursdayOfMonth, "2023-12-11", ExpectedResult = "2023-12-28")]
        [TestCase(ControlDateModifierTypes.Minus2Years, "2023-12-11", ExpectedResult = "2021-12-11")]
        [TestCase(ControlDateModifierTypes.CutOff15ofMonthFollowingWednesday, "2023-12-11", ExpectedResult = "2023-12-20")]
        [TestCase(ControlDateModifierTypes.CutOff15ofMonthFollowingWednesday, "2023-12-24", ExpectedResult = "2024-01-17")]
        [TestCase(ControlDateModifierTypes.CutOff15ofMonthFollowingThursday, "2023-12-11", ExpectedResult = "2023-12-21")]
        [TestCase(ControlDateModifierTypes.CutOff15ofMonthFollowingThursday, "2023-12-25", ExpectedResult = "2024-01-18")]
        public DateTime? ControlDateModifierTypeTest(ControlDateModifierTypes controlDateModifierTypes, DateTime date)
        {
            var dateConfig = new DateConfig(1, 1, ControlDateTypes.SoldDate, controlDateModifierTypes, ControlDateOffsetType.NoOffset, 0);
            var result = dateConfig.GetControlDateModifierType(date);
            return result;
        }

        [Test]
        [TestCase(ControlDateOffsetType.NoOffset, -1, "2023-12-11", ExpectedResult = "2023-12-11")]
        [TestCase(ControlDateOffsetType.NoOffset, 0, "2023-12-11", ExpectedResult = "2023-12-11")]
        [TestCase(ControlDateOffsetType.BusinessDays, 3, "2023-12-11", ExpectedResult = "2023-12-14")]
        [TestCase(ControlDateOffsetType.BusinessDays, 5, "2023-12-11", ExpectedResult = "2023-12-18")]
        [TestCase(ControlDateOffsetType.BusinessDays, 6, "2023-12-11", ExpectedResult = "2023-12-18")]
        [TestCase(ControlDateOffsetType.CalendarDays, 3, "2023-12-11", ExpectedResult = "2023-12-14")]
        [TestCase(ControlDateOffsetType.CalendarDays, 5, "2023-12-11", ExpectedResult = "2023-12-16")]
        [TestCase(ControlDateOffsetType.CalendarDays, 6, "2023-12-11", ExpectedResult = "2023-12-17")]
        [TestCase(ControlDateOffsetType.DayOfMonth, 10, "2023-12-11", ExpectedResult = "2023-12-21")]
        [TestCase(ControlDateOffsetType.DayOfMonth, 24, "2023-12-11", ExpectedResult = "2023-12-31")]
        [TestCase(ControlDateOffsetType.DayOfWeek_Fridays, 2, "2023-12-11", ExpectedResult = "2023-12-29")]
        [TestCase(ControlDateOffsetType.Months, 3, "2023-12-11", ExpectedResult = "2024-03-11")]
        [TestCase(ControlDateOffsetType.Years, 3, "2023-12-11", ExpectedResult = "2026-12-11")]
        [TestCase(ControlDateOffsetType.FirstDayAfterOffSet_Fridays, 5, "2023-12-11", ExpectedResult = "2023-12-22")]
        public DateTime? ControlDateOffsetTypeTest(ControlDateOffsetType controlDateOffsetType, int offsetValue, DateTime date)
        {
            var dateConfig = new DateConfig(1, 1, ControlDateTypes.SoldDate, ControlDateModifierTypes.NoModifier, controlDateOffsetType, offsetValue);
            var result = dateConfig.GetControlDateOffsetType(date);
            return result;
        }
    }
}
