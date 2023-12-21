namespace Core.Entities
{
    public class LengthOfTermQualification : Qualification
    {
        private LengthOfTermQualification()
        {
            
        }
        public LengthOfTermQualification(int id, int? salesProgramId, int minTermMonth, int maxTermMonth)
        {
            Id = id;
            SalesProgramId = salesProgramId;
            MinTermMonth = minTermMonth;
            MaxTermMonth = maxTermMonth;
        }

        public int MinTermMonth { get; private set; }
        public int MaxTermMonth { get; private set; }

        public override bool IsValidQualification(ContractItem contractItem)
        {
            return contractItem.TermMonth <= MinTermMonth && contractItem.TermMonth >= MaxTermMonth;
        }
    }
}
