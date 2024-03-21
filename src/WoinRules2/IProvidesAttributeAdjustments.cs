using System.Collections.Immutable;

namespace WoinRules2;

/// <summary>
///     Interface IProvidesAttributeAdjustments
/// </summary>
public interface IProvidesAttributeAdjustments
{
    /// <summary>
    ///     Gets the attribute adjustments to apply.
    /// </summary>
    /// <value>The attribute adjustments to apply.</value>
    ImmutableArray<AttributeAdjustment> AttributeAdjustmentsToApply { get; }
}