using Core.Entities.Enums;
using Core.Extensions;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class DateConfig
    {
        private DateConfig()
        {
        }

        public DateConfig(int id, int commisionTypeId, ControlDateTypes controlDateType, ControlDateModifierTypes controlDateModifierType, ControlDateOffsetType controlDateOffsetType, int controlDateOffsetValue)
        {
            Id = id;
            CommisionTypeId = commisionTypeId;
            ControlDateType = controlDateType;
            ControlDateModifierType = controlDateModifierType;
            ControlDateOffsetType = controlDateOffsetType;
            ControlDateOffsetValue = controlDateOffsetValue;
        }

        [Key]
        public int Id { get; init; }
        public ControlDateTypes ControlDateType { get; private set; }
        public ControlDateModifierTypes ControlDateModifierType { get; set; }
        public ControlDateOffsetType ControlDateOffsetType { get; private set; }
        public int ControlDateOffsetValue { get; set; }

        public int? CommisionTypeId { get; private set; }
        public CommisionType? CommisionTypes { get; private set; }


        public DateTime GetControlDate(ContractItem contractItem)
        {
            switch (ControlDateType)
            {
                case ControlDateTypes.SoldDate:
                    return contractItem.Contract.SoldDate;
                case ControlDateTypes.ServiceStartDate:
                    return contractItem.StartDate;
                case ControlDateTypes.CustomerInvoiceDate:
                    return contractItem.StartDate.AddMonths(1);
                case ControlDateTypes.CustomerPaymentDate:
                    return contractItem.StartDate.AddMonths(2);
                case ControlDateTypes.SupplierInvoiceDate:
                    return contractItem.StartDate.GetNextWeekday(DayOfWeek.Tuesday);
                case ControlDateTypes.UtilityAcceptanceDate:
                    return contractItem.StartDate.AddMonths(-1);
                default:
                    return contractItem.Contract.SoldDate;
            }
        }

        public DateTime GetControlDateModifierType(DateTime date)
        {
            switch (ControlDateModifierType)
            {
                case ControlDateModifierTypes.NoModifier:
                    return date;
                case ControlDateModifierTypes.EndOfMonth:
                    return date.GetEndOfMonth();
                case ControlDateModifierTypes.EndOfQuarter:
                    return date.GetEndOfQuarter();
                case ControlDateModifierTypes.OneMonthAfter:
                    return date.AddMonths(1);
                case ControlDateModifierTypes.TwoMonthsAfter:
                    return date.AddMonths(2);
                case ControlDateModifierTypes.ThreeMonthsAfter:
                    return date.AddMonths(3);
                case ControlDateModifierTypes.Days2ndOr16thOfMonthAfter:
                    return date.GetDays2ndOr16thOfMonthAfter();
                case ControlDateModifierTypes.DaysAfter15thOfMonthAfter:
                    return date.GetDaysAfter15thOfMonthAfter();
                case ControlDateModifierTypes.OneYearAfter:
                    return date.AddYears(1);
                case ControlDateModifierTypes.Minus3Months:
                    return date.AddMonths(-3);
                case ControlDateModifierTypes.Minus5Months:
                    return date.AddMonths(-5);
                case ControlDateModifierTypes.FirstFridayAfter:
                    return date.GetNextWeekday(DayOfWeek.Friday);
                case ControlDateModifierTypes.DayUpToOrAfter23rd:
                    return date.GetDayUpToOrAfter23rd();
                case ControlDateModifierTypes.LastThursdayOfMonth:
                    return date.GetLastWeekday(DayOfWeek.Thursday);
                case ControlDateModifierTypes.Minus2Years:
                    return date.AddYears(-2);
                case ControlDateModifierTypes.CutOff15ofMonthFollowingWednesday:
                    return date.CutOff15ofMonthFollowingDayofWeek(DayOfWeek.Wednesday);
                case ControlDateModifierTypes.CutOff15ofMonthFollowingThursday:
                    return date.CutOff15ofMonthFollowingDayofWeek(DayOfWeek.Thursday);
                default:
                    return date;
            }
        }

        public DateTime GetControlDateOffsetType(DateTime date)
        {
            if (ControlDateOffsetValue < 0) return date;

            switch (ControlDateOffsetType)
            {
                case ControlDateOffsetType.NoOffset:
                    return date;
                case ControlDateOffsetType.BusinessDays:
                    return date.AddDaysOffset(ControlDateOffsetValue, false);
                case ControlDateOffsetType.CalendarDays:
                    return date.AddDaysOffset(ControlDateOffsetValue, true);
                case ControlDateOffsetType.DayOfMonth:
                    return date.AddDaysOffsetNotOverMonth(ControlDateOffsetValue);
                case ControlDateOffsetType.DayOfWeek_Fridays:
                    var d = date.AddDays(ControlDateOffsetValue * 7);
                    return d.GetNextWeekday(DayOfWeek.Friday);
                case ControlDateOffsetType.Months:
                    return date.AddMonths(ControlDateOffsetValue);
                case ControlDateOffsetType.Years:
                    return date.AddYears(ControlDateOffsetValue);
                case ControlDateOffsetType.FirstDayAfterOffSet_Fridays:
                    var lastDateOfMonth = date.AddDaysOffsetNotOverMonth(ControlDateOffsetValue);
                    return lastDateOfMonth.GetNextWeekday(DayOfWeek.Friday);
                default:
                    return date;
            }
        }

        public DateTime GetForecastDate(ContractItem contractItem)
        {
            var controlDate = GetControlDate(contractItem);
            var controlDateModifierType = GetControlDateModifierType(controlDate);
            var controlDateOffsetType = GetControlDateOffsetType(controlDateModifierType);
            return controlDateOffsetType;
        }
    }
}
