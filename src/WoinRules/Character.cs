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

    /// <summary>
    ///     Gets the careers.
    /// </summary>
    /// <value>The careers.</value>
    public List<Career> Careers { get; } = [];

    /// <summary>
    ///     Gets or sets the descriptor.
    /// </summary>
    /// <value>The descriptor.</value>
    public string Descriptor { get; set; } = string.Empty;

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    ///     Gets the skills.
    /// </summary>
    /// <value>The skills.</value>
    public List<Skill> Skills { get; } = [];
}