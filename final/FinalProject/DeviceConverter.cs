using System;
using System.Text.Json;
using System.Text.Json.Serialization;

public class DeviceConverter : JsonConverter<Device>
{
    public override Device Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        using (JsonDocument jsonDocument = JsonDocument.ParseValue(ref reader))
        {
            JsonElement root = jsonDocument.RootElement;
            string type = root.GetProperty("Type").GetString();

            switch (type)
            {
                case "Light":
                    return JsonSerializer.Deserialize<Light>(root.GetRawText(), options);
                case "Thermostat":
                    return JsonSerializer.Deserialize<Thermostat>(root.GetRawText(), options);
                case "SecurityCamera":
                    return JsonSerializer.Deserialize<SecurityCamera>(root.GetRawText(), options);
                default:
                    throw new NotSupportedException($"Device type '{type}' is not supported.");
            }
        }
    }

    public override void Write(Utf8JsonWriter writer, Device value, JsonSerializerOptions options)
    {
        writer.WriteStartObject();

        writer.WriteString("Type", value.GetType().Name);
        foreach (var property in value.GetType().GetProperties())
        {
            writer.WritePropertyName(property.Name);
            JsonSerializer.Serialize(writer, property.GetValue(value), property.PropertyType, options);
        }

        writer.WriteEndObject();
    }
}
