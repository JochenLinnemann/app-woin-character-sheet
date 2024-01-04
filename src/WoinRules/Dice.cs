using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace WoinRules;

/// <summary>
///     Class Dice.
/// </summary>
[JsonConverter(typeof(DiceConverter))]
public partial class Dice
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Dice" /> class.
    /// </summary>
    /// <param name="diceString">The dice string.</param>
    public Dice(string diceString)
    {
        var match = CreateDiceRegex().Match(diceString);
        Count = int.Parse(match.Groups["Count"].Value);
        Sides = int.Parse(match.Groups["Sides"].Value);

        var adds = match.Groups["Adds"].Value;
        Adds = string.IsNullOrWhiteSpace(adds) ? 0 : int.Parse(adds);
    }

    /// <summary>
    ///     Gets or sets the adds.
    /// </summary>
    /// <value>The adds.</value>
    public int Adds { get; set; }

    /// <summary>
    ///     Gets or sets the count.
    /// </summary>
    /// <value>The count.</value>
    public int Count { get; set; }

    /// <summary>
    ///     Gets or sets the sides.
    /// </summary>
    /// <value>The sides.</value>
    public int Sides { get; set; }

    /// <summary>
    ///     Creates the dice regex.
    /// </summary>
    /// <returns>Regex.</returns>
    [GeneratedRegex(@"(?<Count>\d+)d(?<Sides>\d+)(?<Adds>[+-]\d+)?")]
    private static partial Regex CreateDiceRegex();

    /// <summary>
    ///     Rolls the dice.
    /// </summary>
    /// <returns>DiceRoll.</returns>
    public DiceRoll Roll()
    {
        var dice = new int[Count + (Adds != 0 ? 1 : 0)];
        var total = 0;
        for (var i = 0; i < Count; i++)
        {
            dice[i] = Random.Shared.Next(Sides) + 1;
            total += dice[i];
        }

        if (Adds != 0)
        {
            dice[^1] = Adds;
            total += Adds;
        }

        return new DiceRoll { Sub = dice, Total = total };
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var adds = Adds switch
        {
            0 => "",
            _ => $"{Adds:+#;-#}"
        };

        return $"{Count}d{Sides}{adds}";
    }
}