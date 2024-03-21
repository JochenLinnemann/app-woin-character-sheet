namespace WoinRules2;

/// <summary>
///     Represents dice that may be rolled.
///     The format is "xDy+z" where
///     - x is the number of dice,
///     - y is the number of sides on each die, and
///     - z is a flat modifier applied to the result of a roll.
/// </summary>
public readonly record struct Dice
{
    /// <summary>
    ///     Gets the flat modifier.
    /// </summary>
    /// <value>The flat modifier.</value>
    public int FlatModifier { get; init; }

    /// <summary>
    ///     Gets the number of dice.
    /// </summary>
    /// <value>The number of dice.</value>
    public int NumberOfDice { get; init; }

    /// <summary>
    ///     Gets the number of sides.
    /// </summary>
    /// <value>The number of sides.</value>
    public int NumberOfSides { get; init; }
}