namespace WoinRules;

/// <summary>
///     Class Dice.
/// </summary>
public class Dice(int count, int adds)
{
    /// <summary>
    ///     Gets or sets the adds.
    /// </summary>
    /// <value>The adds.</value>
    public int Adds { get; set; }

    /// <summary>
    ///     Gets or sets the count.
    /// </summary>
    /// <value>The count.</value>
    public int Count { get; set; }

    /// <summary>
    ///     Rolls the dice.
    /// </summary>
    /// <returns>DiceRoll.</returns>
    public DiceRoll Roll()
    {
        var dice = new int[Count + (Adds != 0 ? 1 : 0)];
        var total = 0;
        for (var i = 0; i < Count; i++)
        {
            dice[i] = Random.Shared.Next(6) + 1;
            total += dice[i];
        }

        if (Adds != 0)
        {
            dice[^1] = Adds;
            total += Adds;
        }

        return new DiceRoll { Sub = dice, Total = total };
    }
}