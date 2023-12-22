namespace WoinRules;

/// <summary>
///     Class Attribute.
/// </summary>
public class Attribute
{
    /// <summary>
    ///     Gets the size of the dice pool.
    /// </summary>
    /// <value>The size of the dice pool.</value>
    public int DicePoolSize => TriangularNumbers.CalculateDicePoolSize(Value);

    /// <summary>
    ///     Gets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; init; } = null!;

    /// <summary>
    ///     Gets the short name.
    /// </summary>
    /// <value>The short name.</value>
    public string ShortName { get; init; } = null!;

    /// <summary>
    ///     Gets the start value.
    /// </summary>
    /// <value>The start value.</value>
    public int StartValue { get; init; }

    /// <summary>
    ///     Gets or sets the value.
    /// </summary>
    /// <value>The value.</value>
    public int Value { get; set; }

    /// <summary>
    ///     Rolls the dice.
    /// </summary>
    /// <returns>DiceRoll.</returns>
    public DiceRoll RollDice()
    {
        var dice = new int[DicePoolSize];
        var total = 0;
        for (var i = 0; i < DicePoolSize; i++)
        {
            dice[i] = Random.Shared.Next(6) + 1;
            total += dice[i];
        }

        return new DiceRoll { Sub = dice, Total = total };
    }
}