namespace WoinRules2;

/// <summary>
///     Represents an Adjustment to an Attribute made by IProvidesAttributeAdjustments.
///     The format is "ATT+x" where
///     - ATT is the short name of the attribute, and
///     - x is the adjustment to apply.
/// </summary>
public record AttributeAdjustment
{
    /// <summary>
    ///     Gets the adjustment.
    /// </summary>
    /// <value>The adjustment.</value>
    public int Adjustment { get; init; }

    /// <summary>
    ///     Gets the short name of the attribute.
    /// </summary>
    /// <value>The short name of the attribute.</value>
    public required string AttributeShortName { get; init; }
}