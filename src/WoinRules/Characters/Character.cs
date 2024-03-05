using System.Collections.Immutable;

namespace WoinRules.Characters;

public interface IStatProvider
{
}

public interface IProvidedStat
{
    public IStatProvider Provider { get; }
}

public record Character
{
    public Age? Age { get; init; }

    public ImmutableArray<Attribute> Attributes { get; init; }

    public ImmutableArray<Career> Careers { get; init; }

    public ImmutableArray<DerivedStatistic> DerivedStatistics { get; init; }

    public Descriptor? Descriptor { get; init; }

    public ImmutableArray<Equipment> Equipment { get; init; }

    public ImmutableArray<Exploit> Exploits { get; init; }

    public Heritage? Heritage { get; init; }

    public ImmutableArray<Skill> Skills { get; init; }

    public Trait? Trait { get; init; }

    public static Character Create()
    {
        return new Character
        {
            Attributes =
            [
                new Attribute("Strength", "STR"),
                new Attribute("Agility", "AGI"),
                new Attribute("Endurance", "END"),

                new Attribute("Intuition", "INT"),
                new Attribute("Logic", "LOG"),
                new Attribute("Willpower", "WIL"),

                new Attribute("Charisma", "CHA"),
                new Attribute("Luck", "LUC"),
                new Attribute("Reputation", "REP"),

                new Attribute("Power", "POW", 0, 0)
            ]
        };
    }

    public Character SetHeritage(Heritage heritage, Skill heritageSkill1, Skill heritageSkill2, Skill heritageSkill3)
    {
        var skills = Skills;
        var exploits = Exploits;

        if (Heritage is not null)
        {
            skills = skills.RemoveRange(Heritage.Skills);
            exploits = exploits.RemoveRange(Heritage.Exploits);
        }

        skills = skills.AddRange(heritageSkill1, heritageSkill2, heritageSkill3);
        exploits = exploits.AddRange(heritage.Exploits);

        return this with
        {
            Heritage = heritage,
            // TODO: apply attribute adjustments
            Skills = skills,
            Exploits = exploits
        };
    }
}

public record Heritage
{
    public ImmutableArray<AttributeAdjustment> AttributeAdjustments { get; init; }

    public ImmutableArray<Exploit> Exploits { get; init; }

    public ImmutableArray<Skill> Skills { get; init; }
}

public record Hook
{
}

public record Descriptor
{
    public Hook? Hook { get; init; }
}

public record Career
{
}

public record Exploit
{
}

public record Trait
{
}

public record Age
{
}

public record DerivedStatistic
{
}

public record Equipment
{
}