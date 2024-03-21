namespace WoinRules2;

/// <summary>
///     Interface IProvidesAgeIncrease
/// </summary>
public interface IProvidesAgeIncrease
{
    /// <summary>
    ///     Gets the age increase to apply.
    /// </summary>
    /// <value>The age increase to apply.</value>
    Dice AgeIncreaseToApply { get; }
}