namespace WoinRules;

/// <summary>
///     Class Character.
/// </summary>
/// <param name="era">The era.</param>
/// <remarks>Initializes a new instance of the <see cref="Character" /> class.</remarks>
public class Character(EraOfPlay era)
{
    /// <summary>
    ///     Gets the attributes.
    /// </summary>
    /// <value>The attributes.</value>
    public Attribute[] Attributes { get; } = AttributeFactory.CreateAttributes(era);
}