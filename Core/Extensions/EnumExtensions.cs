using Core.Attributes;
using Core.Entities.Enums;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Core.Extensions
{
    public static class EnumExtensions
    {
        public static string? GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()?
                            .GetName();
        }

        public static List<T> ToList<T>(this T enums)
           where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().ToList<T>();
        }

        public static T ToEnum<T>(this string value)
        {
            return (T)Enum.Parse(typeof(T), value, true);
        }

        public static T ToEnum<T>(this string value, T defaultValue) where T : struct
        {
            if (string.IsNullOrEmpty(value))
            {
                return defaultValue;
            }

            T result;
            return Enum.TryParse(value, true, out result) ? result : defaultValue;
        }

        public static T GetValueFromDisplayName<T>(this string displayName) where T : Enum
        {
            foreach (var field in typeof(T).GetFields())
            {
                if (Attribute.GetCustomAttribute(field,
                typeof(DisplayAttribute)) is DisplayAttribute attribute)
                {
                    if (attribute.Name == displayName)
                        return (T)field.GetValue(null);
                }
                else
                {
                    if (field.Name == displayName)
                        return (T)field.GetValue(null);
                }
            }

            return default(T);
        }

        public static ProductTypes? GetProductType(this EnergyUnitTypes enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<EnergyUnitTypeAttribute>()?
                            .ProductType ?? ProductTypes.None;
        }
    }
}
