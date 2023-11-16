using Core.Attributes;

namespace Core.Entities.Enums
{
    public enum EnergyUnitTypes
    {
        [EnergyUnitType(ProductTypes.Elec)]
        KWH = 0,
        [EnergyUnitType(ProductTypes.Gas)]
        CCF = 1,
        [EnergyUnitType(ProductTypes.Elec)]
        MWH = 2,
        [EnergyUnitType(ProductTypes.Gas)]
        THM = 3,
        [EnergyUnitType(ProductTypes.Gas)]
        MCF = 4
    }
}
