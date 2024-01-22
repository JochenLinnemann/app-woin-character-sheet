using System.Text.Json;
using System.Text.Json.Serialization;

namespace WoinRules.Careers;

/// <summary>
///     Class AttributeAdjustmentConverter.
///     Implements the <see cref="JsonConverter" />
/// </summary>
/// <seealso cref="JsonConverter`1" />
public class AttributeAdjustmentConverter : JsonConverter<AttributeAdjustment>
{
    /// <inheritdoc />
    public override AttributeAdjustment? Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        return new AttributeAdjustment(reader.GetString() ?? "");
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, AttributeAdjustment value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}