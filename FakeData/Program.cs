// See https://aka.ms/new-console-template for more information
using Bogus;
using Newtonsoft.Json;

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
