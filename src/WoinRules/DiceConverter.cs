using System.Text.Json;
using System.Text.Json.Serialization;

namespace WoinRules;

/// <summary>
///     Class DiceConverter.
///     Implements the <see cref="System.Text.Json.Serialization.JsonConverter{WoinRules.Dice}" />
/// </summary>
/// <seealso cref="System.Text.Json.Serialization.JsonConverter{WoinRules.Dice}" />
public class DiceConverter : JsonConverter<Dice>
{
    /// <inheritdoc />
    public override Dice? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return new Dice(reader.GetString() ?? "");
    }

    /// <inheritdoc />
    public override void Write(Utf8JsonWriter writer, Dice value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}