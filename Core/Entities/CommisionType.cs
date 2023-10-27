using Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class CommisionType
    {
        public CommisionType(int id, int? salesProgramId, int? commissionConfigurationTypeId, int? dateConfigId, ProgramAdderType programAdderType, double? programAdder, decimal marginPercent)
        {
            Id = id;
            SalesProgramId = salesProgramId;
            CommissionConfigurationTypeId = commissionConfigurationTypeId;
            DateConfigId = dateConfigId;
            ProgramAdderType = programAdderType;
            ProgramAdder = programAdder;
            MarginPercent = marginPercent;
        }

        [Key]
        public int Id { get; init; }
        [Required]
        public int? CommissionConfigurationTypeId { get; set; }
        public CommissionConfigurationType? CommissionConfigurationType { get; set; }

        public int? DateConfigId { get; set; }
        public DateConfig? DateConfig { get; set; }

        public ProgramAdderType ProgramAdderType { get; set; }
        public double? ProgramAdder { get; set; }
        public decimal MarginPercent { get; set; }

        [Required]
        public int? SalesProgramId { get; set; }
        public SaleProgram? SaleProgram { get; set; }
    }
}
