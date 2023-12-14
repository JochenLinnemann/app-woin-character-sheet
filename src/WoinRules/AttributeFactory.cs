namespace WoinRules;

/// <summary>
///     Class AttributeFactory.
/// </summary>
public static class AttributeFactory
{
    /// <summary>
    ///     Creates the attributes for a character of a given era.
    /// </summary>
    /// <param name="era">The era.</param>
    /// <returns>Attribute[].</returns>
    public static Attribute[] CreateAttributes(EraOfPlay era)
    {
        var attributes = new Attribute[10];

        attributes[0] = new Attribute { Name = "Strength", ShortName = "STR", StartValue = 3, Value = 3 };
        attributes[1] = new Attribute { Name = "Agility", ShortName = "AGL", StartValue = 3, Value = 3 };
        attributes[2] = new Attribute { Name = "Endurance", ShortName = "END", StartValue = 3, Value = 3 };

        attributes[3] = new Attribute { Name = "Intuition", ShortName = "INT", StartValue = 3, Value = 3 };
        attributes[4] = new Attribute { Name = "Logic", ShortName = "LOG", StartValue = 3, Value = 3 };
        attributes[5] = new Attribute { Name = "Willpower", ShortName = "WIL", StartValue = 3, Value = 3 };

        attributes[6] = new Attribute { Name = "Charisma", ShortName = "CHA", StartValue = 3, Value = 3 };
        attributes[7] = new Attribute { Name = "Luck", ShortName = "LUC", StartValue = 3, Value = 3 };
        attributes[8] = new Attribute { Name = "Reputation", ShortName = "REP", StartValue = 3, Value = 3 };

        attributes[9] = era switch
        {
            EraOfPlay.Generic => new Attribute { Name = "Power", ShortName = "POW", StartValue = 0, Value = 0 },
            EraOfPlay.Archaic => new Attribute { Name = "Magic", ShortName = "MAG", StartValue = 0, Value = 0 },
            EraOfPlay.Modern => new Attribute { Name = "Chi", ShortName = "CHI", StartValue = 0, Value = 0 },
            EraOfPlay.Future => new Attribute { Name = "Psionics", ShortName = "PSI", StartValue = 0, Value = 0 },
            _ => throw new ArgumentOutOfRangeException(nameof(era), era, null)
        };

        return attributes;
    }
}