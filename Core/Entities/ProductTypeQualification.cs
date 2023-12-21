using Core.Entities.Enums;

namespace Core.Entities
{
    public class ProductTypeQualification : Qualification
    {
        private ProductTypeQualification()
        {
        }
        public ProductTypeQualification(int id, int? salesProgramId, ProductTypes productType, bool isIncludedProductType)
        {
            Id = id;
            SalesProgramId = salesProgramId;
            ProductType = productType;
            IsIncludedProductType = isIncludedProductType;
        }

        public ProductTypes ProductType { get; private set; }
        public bool IsIncludedProductType { get; private set; }

        public override bool IsValidQualification(ContractItem contractItem)
        {
            return (IsIncludedProductType && contractItem.ProductType == ProductType) || (!IsIncludedProductType && contractItem.ProductType != ProductType);
        }
    }
}
