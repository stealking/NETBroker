using Core.Entities.Enums;

namespace Core.Attributes
{
    public class EnergyUnitTypeAttribute : Attribute
    {
        public ProductTypes ProductType { get; private set; }
        public EnergyUnitTypeAttribute(ProductTypes productType)
        {
            ProductType = productType;
        }
    }
}
