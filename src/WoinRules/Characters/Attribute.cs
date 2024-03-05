using System.Collections.Immutable;

namespace WoinRules.Characters;

public record ProvidedStat<TStat, TProvider>(TStat Stat, TProvider Provider);

/// <summary>
///     Class Attribute.
///     Implements the <see cref="IEquatable{Attribute}" />
/// </summary>
/// <param name="Name">The name of the attribute, e.g., "Strength"</param>
/// <param name="ShortName">The short name of the attribute, e.g., "STR"</param>
/// <param name="StartValue">The start value this attribute normally has, 3 for most attributes.</param>
/// <param name="Value">The actual value of the attribute.</param>
/// <seealso cref="IEquatable{Attribute}" />
public record Attribute(string Name, string ShortName, int StartValue = 3, int Value = 3)
{
    private ImmutableArray<ProvidedStat<AttributeAdjustment, IAttributeAdjustmentProvider>> _adjustments = [];

    public Attribute Apply(AttributeAdjustment adjustment, IAttributeAdjustmentProvider providedBy)
    {
        if (adjustment.ShortName != ShortName)
            return this;

        var adjustments = _adjustments.Add(
            new ProvidedStat<AttributeAdjustment, IAttributeAdjustmentProvider>(adjustment, providedBy));
        var value = StartValue + adjustments.Sum(a => a.Stat.Value);

        return this with
        {
            _adjustments = adjustments,
            Value = value
        };
    }

    public Attribute Remove(AttributeAdjustment adjustment, IAttributeAdjustmentProvider providedBy)
    {
        if (adjustment.ShortName != ShortName)
            return this;

        var adjustments = _adjustments.Remove(
            new ProvidedStat<AttributeAdjustment, IAttributeAdjustmentProvider>(adjustment, providedBy));
        var value = StartValue + adjustments.Sum(a => a.Stat.Value);

        return this with
        {
            _adjustments = adjustments,
            Value = value
        };
    }
}

public record AttributeAdjustment(string ShortName, int Value);

public interface IAttributeAdjustmentProvider
{
}