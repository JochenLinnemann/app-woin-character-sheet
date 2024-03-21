namespace WoinRules2;

/// <summary>
///     Represents a skill level supplied by IProvidesSkillLevels.
/// </summary>
public record SkillLevel
{
    /// <summary>
    ///     Gets the name of the skill.
    /// </summary>
    /// <value>The name of the skill.</value>
    public required string SkillName { get; init; }
}