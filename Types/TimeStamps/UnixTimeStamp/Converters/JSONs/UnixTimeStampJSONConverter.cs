﻿using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Kudos.Coring.Types.TimeStamps.UnixTimeStamp;

namespace Kudos.Coring.Types.TimeStamps.UnixTimeStamp.Converters.JSONs
{
    public class UnixTimeStampJSONConverter : JsonConverter<UnixTimeStamp>
    {
        public override UnixTimeStamp Read(
            ref Utf8JsonReader oUtf8JsonReader,
            Type typeToConvert,
            JsonSerializerOptions oJsonSerializerOptions
        )
        {
            try { return new UnixTimeStamp(oUtf8JsonReader.GetUInt64()); }
            catch { return UnixTimeStamp.GetOrigin(); }
        }

        public override void Write(
            Utf8JsonWriter oUtf8JsonWriter,
            UnixTimeStamp oUnixTimeStamp,
            JsonSerializerOptions oJsonSerializerOptions
        )
        {
            try { oUtf8JsonWriter.WriteNumberValue(oUnixTimeStamp.Milliseconds); }
            catch { oUtf8JsonWriter.WriteNumberValue(0); }
        }
    }
}