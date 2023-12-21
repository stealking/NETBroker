namespace Core.Entities
{
    public class AnnualUssageQualification : Qualification
    {
        public AnnualUssageQualification()
        {
            
        }
        public AnnualUssageQualification(int id, int salesProgramId, int fromAnnualUsage, int toAnnualUsage)
        {
            Id = id;
            SalesProgramId = salesProgramId;
            FromAnnualUsage = fromAnnualUsage;
            ToAnnualUsage = toAnnualUsage;
        }

        public int FromAnnualUsage { get; set; }
        public int ToAnnualUsage { get; set; }

        public override bool IsValidQualification(ContractItem contractItem)
        {
            return FromAnnualUsage >= contractItem.AnnualUsage && contractItem.AnnualUsage <= ToAnnualUsage;
        }
    }
}
