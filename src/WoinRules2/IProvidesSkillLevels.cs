using System.Collections.Immutable;

namespace WoinRules2;

/// <summary>
///     Interface IProvidesSkillLevels
/// </summary>
public interface IProvidesSkillLevels
{
    /// <summary>
    ///     Gets the list of skill levels to choose from.
    /// </summary>
    /// <value>The list of skill levels to choose from.</value>
    ImmutableArray<SkillLevel> ListOfSkillLevelsToChooseFrom { get; }

    /// <summary>
    ///     Gets the number of skill levels to choose.
    /// </summary>
    /// <value>The number of skill levels to choose.</value>
    int NumberOfSkillLevelsToChoose { get; }
}