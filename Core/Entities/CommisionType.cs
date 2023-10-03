using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class CommisionType
    {
        public CommisionType()
        {
        }

        public CommisionType(int id, int salesProgramId, string? commissionConfigurationTypeId, string? programAdderType, double? programAdder, string? marginPercent)
        {
            Id = id;
            SalesProgramId = salesProgramId;
            CommissionConfigurationTypeId = commissionConfigurationTypeId;
            ProgramAdderType = programAdderType;
            ProgramAdder = programAdder;
            MarginPercent = marginPercent;
        }

        [Key]
        public int Id { get; set; }
        [Required]
        public int SalesProgramId { get; set; }
        public string? CommissionConfigurationTypeId { get; set; }
        public string? ProgramAdderType { get; set; }
        public double? ProgramAdder { get; set; }
        public string? MarginPercent { get; set; }

        public SaleProgram? SaleProgram { get; set; }
    }
}
