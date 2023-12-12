namespace WoinRules;

/// <summary>
///     Class TriangularNumbers.
/// </summary>
public static class TriangularNumbers
{
    /// <summary>
    ///     Calculates the size of the dice pool for the given value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <returns>System.Int32.</returns>
    public static int CalculateDicePoolSize(int value)
    {
        return (int)Math.Floor(0.5 * (Math.Sqrt(8 * value + 1) - 1));
    }

    /// <summary>
    ///     Calculates the minimum value needed to achieve the given dice pool size.
    /// </summary>
    /// <param name="dicePoolSize">Size of the dice pool.</param>
    /// <returns>System.Int32.</returns>
    public static int CalculateMinimumValue(int dicePoolSize)
    {
        return dicePoolSize * (dicePoolSize + 1) / 2;
    }
}