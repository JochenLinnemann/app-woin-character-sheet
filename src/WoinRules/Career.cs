namespace WoinRules;

/// <summary>
///     Class Career.
/// </summary>
public class Career
{
    // TODO: Prerequisites

    /// <summary>
    ///     Gets or sets the attributes.
    /// </summary>
    /// <value>The attributes.</value>
    public List<Attribute> Attributes { get; set; } = [];

    /// <summary>
    ///     Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
    public required string Description { get; set; }

    /// <summary>
    ///     Gets or sets the exploits.
    /// </summary>
    /// <value>The exploits.</value>
    public List<Exploit> Exploits { get; set; } = [];

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public required string Name { get; set; }

    /// <summary>
    ///     Gets or sets the skill choices.
    /// </summary>
    /// <value>The skill choices.</value>
    public List<Skill> SkillChoices { get; set; } = [];

    /// <summary>
    ///     Gets or sets the years.
    /// </summary>
    /// <value>The years.</value>
    public required Dice Years { get; set; }
}