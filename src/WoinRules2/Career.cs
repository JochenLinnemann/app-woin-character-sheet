using System.Collections.Immutable;

namespace WoinRules2;

/// <summary>
///     Represents a Career a Character may choose for their LivePath.
/// </summary>
public record Career :
    IHasName, IHasDescription, IHasPrerequisites,
    IProvidesAttributeAdjustments, IProvidesSkillLevels, IProvidesExploits, IProvidesAgeIncrease
{
    /// <summary>
    ///     Gets a value indicating whether this career represents an origin.
    /// </summary>
    /// <value><c>true</c> if this career represents an origin; otherwise, <c>false</c>.</value>
    public bool IsOrigin { get; init; }

    /// <inheritdoc />
    public required string Description { get; init; }

    /// <inheritdoc />
    public required string Name { get; init; }

    /// <inheritdoc />
    public ImmutableArray<Prerequisite> Prerequisites { get; init; }

    /// <inheritdoc />
    public Dice AgeIncreaseToApply { get; init; }

    /// <inheritdoc />
    public ImmutableArray<AttributeAdjustment> AttributeAdjustmentsToApply { get; init; }

    /// <inheritdoc />
    public ImmutableArray<Exploit> ListOfExploitsToChooseFrom { get; init; }

    /// <inheritdoc />
    public ImmutableArray<SkillLevel> ListOfSkillLevelsToChooseFrom { get; init; }

    /// <inheritdoc />
    public int NumberOfSkillLevelsToChoose { get; init; }
}

/// <summary>
///     Represents a Heritage a Character may choose.
/// </summary>
public record Heritage :
    IHasName, IHasDescription, IHasPrerequisites,
    IProvidesAttributeAdjustments, IProvidesSkillLevels, IProvidesExploits
{
    /// <inheritdoc />
    public required string Description { get; init; }

    /// <inheritdoc />
    public required string Name { get; init; }

    /// <inheritdoc />
    public ImmutableArray<Prerequisite> Prerequisites { get; init; }

    /// <inheritdoc />
    public ImmutableArray<AttributeAdjustment> AttributeAdjustmentsToApply { get; init; }

    /// <inheritdoc />
    public ImmutableArray<Exploit> ListOfExploitsToChooseFrom { get; init; }

    /// <inheritdoc />
    public ImmutableArray<SkillLevel> ListOfSkillLevelsToChooseFrom { get; init; }

    /// <inheritdoc />
    public int NumberOfSkillLevelsToChoose { get; init; }
}

public class Exploit
{
}

public class Prerequisite
{
}