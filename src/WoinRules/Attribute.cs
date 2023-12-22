namespace WoinRules;

/// <summary>
///     Class Attribute.
///     Implements the <see cref="Rollable" />
/// </summary>
public class Attribute : Rollable
{
    /// <summary>
    ///     Gets the short name.
    /// </summary>
    /// <value>The short name.</value>
    public string ShortName { get; init; } = null!;
}