using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class DateConfig
    {
        public DateConfig()
        {
        }

        public DateConfig(int id, string? controlDateType, string? controlDateModifierType, string? controlDateOffsetType, double controlDateOffsetValue)
        {
            Id = id;
            ControlDateType = controlDateType;
            ControlDateModifierType = controlDateModifierType;
            ControlDateOffsetType = controlDateOffsetType;
            ControlDateOffsetValue = controlDateOffsetValue;
        }

        [Key]
        public int Id { get; set; }
        public string? ControlDateType { get; set; }
        public string? ControlDateModifierType { get; set; }
        public string? ControlDateOffsetType { get; set; }
        public double ControlDateOffsetValue { get; set; }
    }
}
