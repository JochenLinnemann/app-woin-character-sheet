namespace WoinRules;

/// <summary>
///     Class DiceRoll.
/// </summary>
public class DiceRoll
{
    /// <summary>
    ///     Gets a value indicating whether this instance is maybe critical.
    /// </summary>
    /// <value><c>true</c> if this instance is maybe critical; otherwise, <c>false</c>.</value>
    public bool IsMaybeCritical => Sub.Count(x => x == 6) >= 3;

    /// <summary>
    ///     Gets or sets the sub.
    /// </summary>
    /// <value>The sub.</value>
    public required int[] Sub { get; set; }

    /// <summary>
    ///     Gets or sets the total.
    /// </summary>
    /// <value>The total.</value>
    public int Total { get; set; }

    /// <summary>
    ///     Converts to string.
    /// </summary>
    /// <returns>string.</returns>
    public override string ToString()
    {
        return string.Join(" + ", Sub) + " = " + Total + (IsMaybeCritical ? " (critical?)" : "");
    }
}