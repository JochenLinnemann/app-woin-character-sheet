namespace WoinRules;

/// <summary>
///     Class SelectedCareer.
/// </summary>
public class SelectedCareer(Career career)
{
    /// <summary>
    ///     Gets or sets the career.
    /// </summary>
    /// <value>The career.</value>
    public required Career Career { get; init; } = career;

    /// <summary>
    ///     Gets or sets the exploit.
    /// </summary>
    /// <value>The exploit.</value>
    public required Exploit Exploit { get; set; }

    /// <summary>
    ///     Gets or sets the skill one.
    /// </summary>
    /// <value>The skill one.</value>
    public required Skill SkillOne { get; set; }

    /// <summary>
    ///     Gets or sets the skill two.
    /// </summary>
    /// <value>The skill two.</value>
    public required Skill SkillTwo { get; set; }

    /// <summary>
    ///     Gets or sets the years.
    /// </summary>
    /// <value>The years.</value>
    public DiceRoll Years { get; set; } = career.Years.Roll();
}