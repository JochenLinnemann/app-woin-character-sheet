using System.Reflection;
using System.Text.Json;

namespace WoinRules.Careers;

/// <summary>
///     Class Career.
/// </summary>
public class Career
{
    // TODO: Prerequisites

    /// <summary>
    ///     Gets or sets the attribute adjustments.
    /// </summary>
    /// <value>The attribute adjustments.</value>
    public List<AttributeAdjustment> AttributeAdjustments { get; set; } = [];

    /// <summary>
    ///     Gets or sets the description.
    /// </summary>
    /// <value>The description.</value>
    public required string Description { get; set; }

    /// <summary>
    ///     Gets or sets the exploit choices.
    /// </summary>
    /// <value>The exploit choices.</value>
    public List<Exploit> ExploitChoices { get; set; } = [];

    /// <summary>
    ///     Gets or sets the name.
    /// </summary>
    /// <value>The name.</value>
    public required string Name { get; set; }

    /// <summary>
    ///     Gets or sets the skill choices.
    /// </summary>
    /// <value>The skill choices.</value>
    public List<string> SkillChoices { get; set; } = [];

    /// <summary>
    ///     Gets or sets the years.
    /// </summary>
    /// <value>The years.</value>
    public required Dice Years { get; set; }

    /// <summary>
    ///     Loads the origins.
    /// </summary>
    /// <param name="eraOfPlay">The era of play.</param>
    /// <returns>System.Collections.Generic.List&lt;WoinRules.Careers.Career&gt;.</returns>
    public static List<Career> LoadOrigins(EraOfPlay eraOfPlay)
    {
        var careerFile = eraOfPlay switch
        {
            EraOfPlay.Generic => "generic-origins.json",
            EraOfPlay.Archaic => "fantasy-origins.json",
            EraOfPlay.Modern => "modern-origins.json",
            EraOfPlay.Future => "future-origins.json",
            _ => throw new ArgumentOutOfRangeException(nameof(eraOfPlay), eraOfPlay, null)
        };

        var careersStream =
            Assembly.GetExecutingAssembly().GetManifestResourceStream($"WoinRules.Careers.{careerFile}");
        var careersReader = new StreamReader(careersStream ?? throw new InvalidOperationException());
        var careersJson = careersReader.ReadToEnd();
        var careersData = JsonSerializer.Deserialize<List<Career>>(careersJson, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        }) ?? [];

        return careersData;
    }
}