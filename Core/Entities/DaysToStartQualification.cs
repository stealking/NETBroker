namespace Core.Entities
{
    public class DaysToStartQualification : Qualification
    {
        private DaysToStartQualification()
        {
        }
        public DaysToStartQualification(int id, int? salesProgramId, int daysToStart, bool moreThanXDays) 
        {
            Id = id;
            SalesProgramId = salesProgramId;
            DaysToStart = daysToStart;
            MoreThanXDays = moreThanXDays;
        }

        public int DaysToStart { get; private set; }

        public bool MoreThanXDays { get; private set; }

        public override bool IsValidQualification(ContractItem contractItem)
        {
            if (MoreThanXDays)
            {
                return (contractItem.Contract.SoldDate - contractItem.StartDate).Days < DaysToStart;
            }
            else
            {
                return (contractItem.Contract.SoldDate - contractItem.StartDate).Days > DaysToStart;
            }
        }
    }
}
