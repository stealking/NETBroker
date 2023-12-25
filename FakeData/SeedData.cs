using Bogus;
using Core.Entities;
using Core.Entities.Enums;

namespace FakeData
{
    public static class SeedData
    {
        public static List<Supplier> SeedDataSupplier(int count)
        {
            var fakeSupplier = new Faker<Supplier>()
                .RuleFor(x => x.Name, f => f.Person.FullName)
                .RuleFor(x => x.IsActive, f => true)
                .RuleFor(x => x.Creator, f => 1);

            return fakeSupplier.Generate(count);
        }

        public static List<Contract> SeedDataContract(List<int> suppliers, int count)
        {
            var fakeDataContract = new Faker<Contract>()
                 .RuleFor(x => x.LegalEntityName, f => f.Person.FullName)
                .RuleFor(x => x.SoldDate, f => DateTime.Now)
                .RuleFor(x => x.BillingChargeType, f => f.PickRandom<BillingChargeTypes>())
                .RuleFor(x => x.BillingType, f => f.PickRandom<BillingTypes>())
                .RuleFor(x => x.EnrollmentType, f => f.PickRandom<EnrollmentTypes>())
                .RuleFor(x => x.PricingType, f => f.PickRandom<PricingTypes>())
                .RuleFor(x => x.SupplierId, f => f.PickRandom(suppliers))
                .RuleFor(x => x.ContactId, f => f.Random.Number(1, 5))
                .RuleFor(x => x.CloserId, f => 1)
                .RuleFor(x => x.FronterId, f => 1)
                .RuleFor(x => x.CustomerId, f => f.Random.Number(1, 2));

            return fakeDataContract.Generate(count);
        }

        public static List<ContractItem> SeedDataContractItem(List<Contract> contracts, int count)
        {
            var fakeDataContractItem = new Faker<ContractItem>()
                .RuleFor(x => x.UtilityAccountNumber, f => f.Random.Number(10000, 10000000).ToString())
                .RuleFor(x => x.Contract, f => f.PickRandom(contracts))
                .RuleFor(x => x.StartDate, f => f.Date.Between(new DateTime(2022, 01, 01), new DateTime(2023, 12, 31)))
                .RuleFor(x => x.TermMonth, f => f.Random.Number(1, 12))
                .RuleFor(x => x.ProductType, f => f.PickRandom<ProductTypes>())
                .RuleFor(x => x.EnergyUnitType, f => f.PickRandom<EnergyUnitTypes>())
                .RuleFor(x => x.Rate, f => f.Random.Decimal(0, 1, 4))
                .RuleFor(x => x.Adder, f => f.Random.Decimal(0, 1, 4))
                .RuleFor(x => x.Status, f => f.PickRandom<Status>())
                .RuleFor(x => x.AnnualUsage, f => f.Random.Number(100, 9999999))
                .RuleFor(x => x.ContractMargin, f => f.Random.Decimal(1000, 9999999, 0));

            return fakeDataContractItem.Generate(count);
        }
    }
}
