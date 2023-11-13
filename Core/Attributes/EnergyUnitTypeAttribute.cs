using Core.Entities.Enums;

namespace Core.Attributes
{
    public class EnergyUnitTypeAttribute : Attribute
    {
        public ProductType ProductType { get; private set; }
        public EnergyUnitTypeAttribute(ProductType productType)
        {
            ProductType = productType;
        }
    }
}
