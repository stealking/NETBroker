namespace Core.Entities
{
    public class AnnualUssageQualification : Qualification
    {
        private AnnualUssageQualification()
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
    }
}
