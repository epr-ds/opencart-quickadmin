using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace Models.Converters
{
    internal class DateTimeConverter : DateTimeConverterBase
    {
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            string v = reader.Value?.ToString();
            return DateTime.TryParse(v, out DateTime result) ? result : DateTime.MinValue;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
            => writer.WriteValue(((DateTime)value != DateTime.MinValue) ? ((DateTime)value).ToString("yyyy-MM-dd HH:mm:ss") : "0000-00-00 00:00:00");
    }
}
