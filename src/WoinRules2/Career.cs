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

public class Character
{
}

public class CharacterBuilder
{
    public Character CurrentCharacter { get; }

    public CharacterBuilder AddCareer(Career career)
    {
        if (!CheckPrerequisites(career))
            return this;

        // TODO: Implement this method
        // - Add career
        //   - Apply attribute adjustments
        //   - Apply skill levels
        //   - Apply exploits
        //   - Apply age increase

        return this;
    }

    public bool CheckPrerequisites(IHasPrerequisites hasPrerequisites)
    {
        // TODO: Implement this method
        // - Check if the character meets the prerequisites for the given career or heritage.
        // - If the character does not meet the prerequisites, return false.
        // - Log any unmet prerequisites.
        // - If the character meets the prerequisites, return true.

        return true;
    }

    public CharacterBuilder RemoveCareer(Career career)
    {
        // TODO: Check whether the character would still be valid if the career were removed
        if (!CheckPrerequisites(career))
            return this;

        // TODO: Implement this method
        // - Remove career
        //   - Remove attribute adjustments
        //   - Remove skill levels
        //   - Remove exploits
        //   - Remove age increase

        return this;
    }

    public CharacterBuilder SetHeritage(Heritage heritage)
    {
        if (!CheckPrerequisites(heritage))
            return this;

        // TODO: Implement this method
        // - Remove current heritage
        //   - Remove attribute adjustments
        //   - Remove skill levels
        //   - Remove exploits
        // - Set new heritage
        //   - Apply attribute adjustments
        //   - Apply skill levels
        //   - Apply exploits

        return this;
    }

    public CharacterBuilder SetOrigin(Career origin)
    {
        if (!CheckPrerequisites(origin))
            return this;

        // TODO: Implement this method
        // - Remove current origin
        //   - Remove attribute adjustments
        //   - Remove skill levels
        //   - Remove exploits
        //   - Remove age increase
        // - Set new origin
        //   - Apply attribute adjustments
        //   - Apply skill levels
        //   - Apply exploits
        //   - Apply age increase

        return this;
    }
}