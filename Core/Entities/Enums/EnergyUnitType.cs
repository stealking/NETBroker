using Core.Attributes;

namespace Core.Entities.Enums
{
    public enum EnergyUnitType
    {
        [EnergyUnitType(ProductType.Elec)]
        KWH = 0,
        [EnergyUnitType(ProductType.Gas)]
        CCF = 1,
        [EnergyUnitType(ProductType.Elec)]
        MWH = 2,
        [EnergyUnitType(ProductType.Gas)]
        THM = 3,
        [EnergyUnitType(ProductType.Gas)]
        MCF = 4
    }
}
