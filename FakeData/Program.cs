// See https://aka.ms/new-console-template for more information
using Bogus;
using Core.Entities.Enums;
using Core.Models.Requests.ContractItems;
using Core.Models.Requests.Contracts;
using Newtonsoft.Json;

var contractItem = new Faker<ContractItemRequest>()
    .RuleFor(x => x.UtilityAccountNumber, f => f.Random.Number(10000, 10000000).ToString())
    .RuleFor(x => x.StartDate, f => f.Date.Recent(0))
    .RuleFor(x => x.TermMonth, f => f.Random.Number(1, 12))
    .RuleFor(x => x.ProductType, f => f.PickRandom<ProductTypes>())
    .RuleFor(x => x.EnergyUnitType, f => f.PickRandom<EnergyUnitTypes>())
    .RuleFor(x => x.AnnualUsage, f => f.Random.Number(1, 10000))
    .RuleFor(x => x.Rate, f => f.Random.Decimal(0, 1, 4))
    .RuleFor(x => x.Adder, f => f.Random.Decimal(0, 1, 4));


var contract = new Faker<ContractRequest>()
    .RuleFor(x => x.LegalEntityName, f => f.Person.FullName)
    .RuleFor(x => x.SoldDate, f => DateTime.Now)
    .RuleFor(x => x.BillingChargeType, f => f.PickRandom<BillingChargeTypes>())
    .RuleFor(x => x.BillingType, f => f.PickRandom<BillingTypes>())
    .RuleFor(x => x.EnrollmentType, f => f.PickRandom<EnrollmentTypes>())
    .RuleFor(x => x.PricingType, f => f.PickRandom<PricingTypes>())
    .RuleFor(x => x.SupplierId, f => f.Random.Number(1, 4))
    .RuleFor(x => x.ContactId, f => f.Random.Number(1, 5))
    .RuleFor(x => x.CloserId, f => f.Random.Number(1, 1))
    .RuleFor(x => x.FronterId, f => f.Random.Number(1, 1))
    .RuleFor(x => x.CustomerId, f => f.Random.Number(1, 2))
    .RuleFor(x => x.ContractItemRequests, f => contractItem.Generate(2));

Console.WriteLine(contract.Generate().Dump());
Console.ReadLine();

public static class ExtensionsForRandomizer
{
    public static decimal Decimal(this Randomizer r, decimal min = 0.0m, decimal max = 1.0m, int? decimals = null)
    {
        var value = r.Decimal(min, max);
        if (decimals.HasValue)
        {
            return Math.Round(value, decimals.Value);
        }
        return value;
    }

    public static string Dump(this object obj)
    {
        return JsonConvert.SerializeObject(obj, Formatting.Indented);
    }
}
