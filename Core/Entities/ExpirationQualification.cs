namespace Core.Entities
{
    public class ExpirationQualification : Qualification
    {
        private ExpirationQualification()
        {
            
        }
        public ExpirationQualification(int id, int salesProgramId, DateTime effectiveDate, DateTime expiryDate)
        {
            Id = id;
            SalesProgramId = salesProgramId;
            EffectiveDate = effectiveDate;
            ExpiryDate = expiryDate;
        }

        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
