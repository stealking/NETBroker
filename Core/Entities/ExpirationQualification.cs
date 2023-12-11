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

        public DateTime EffectiveDate { get; private set; }
        public DateTime ExpiryDate { get; private set; }

        public override bool IsValidQualification(ContractItem contractItem)
        {
            return EffectiveDate >= contractItem.StartDate && contractItem.StartDate <= ExpiryDate;
        }
    }
}
