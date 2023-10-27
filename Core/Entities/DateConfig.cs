using Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class DateConfig
    {
        public DateConfig()
        {
        }

        public DateConfig(int id, string? controlDateType, string? controlDateModifierType, ControlDateOffsetType controlDateOffsetType, decimal controlDateOffsetValue)
        {
            Id = id;
            ControlDateType = controlDateType;
            ControlDateModifierType = controlDateModifierType;
            ControlDateOffsetType = controlDateOffsetType;
            ControlDateOffsetValue = controlDateOffsetValue;
        }

        [Key]
        public int Id { get; init; }
        public string? ControlDateType { get; set; }
        public string? ControlDateModifierType { get; set; }
        public ControlDateOffsetType ControlDateOffsetType { get; set; }
        public decimal ControlDateOffsetValue { get; set; }

        public ICollection<CommisionType>? CommisionTypes { get; set; }
    }
}
