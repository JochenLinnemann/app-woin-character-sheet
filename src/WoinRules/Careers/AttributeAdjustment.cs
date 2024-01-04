using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

namespace WoinRules.Careers;

/// <summary>
///     Class AttributeAdjustment.
/// </summary>
[JsonConverter(typeof(AttributeAdjustmentConverter))]
public partial class AttributeAdjustment
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AttributeAdjustment" /> class.
    /// </summary>
    /// <param name="attributeAdjustmentString">The attribute adjustment string.</param>
    [SetsRequiredMembers]
    public AttributeAdjustment(string attributeAdjustmentString)
    {
        var match = CreateAttributeAdjustmentRegex().Match(attributeAdjustmentString);
        AttributeShortName = match.Groups["AttributeShortName"].Value;
        AdjustmentValue = int.Parse(match.Groups["AdjustmentValue"].Value);
    }

    /// <summary>
    ///     Gets or sets the adjustment value.
    /// </summary>
    /// <value>The adjustment value.</value>
    public int AdjustmentValue { get; set; }

    /// <summary>
    ///     Gets or sets the short name of the attribute.
    /// </summary>
    /// <value>The short name of the attribute.</value>
    public required string AttributeShortName { get; set; }

    /// <summary>
    ///     Creates the attribute adjustment regex.
    /// </summary>
    /// <returns>System.Text.RegularExpressions.Regex.</returns>
    [GeneratedRegex(@"(?<AttributeShortName>\w{3})(?<AdjustmentValue>[+-]\d)")]
    private static partial Regex CreateAttributeAdjustmentRegex();

    /// <inheritdoc />
    public override string ToString()
    {
        return $"{AttributeShortName}{AdjustmentValue:+#;-#}";
    }
}